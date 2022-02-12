using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Final
{
    public partial class Islemler : Form
    {
        private Component album = null;

        private Component secilenAlbum = null;

        private Component secilenFoto = null;

        private FormatHandler jpgHandler = new ConcreteHandlerJpg();

        private FormatHandler pngHandler = new ConcreteHandlerPng();

        private FormatHandler bmpHandler = new ConcreteHandlerBmp();

        public Islemler(Component album)
        {
            InitializeComponent();

            button1.Enabled = false;

            label7.Enabled = false;

            this.album = album;

            List<string> formatlar = new List<string>(); formatlar.Add(".png"); formatlar.Add(".jpg"); formatlar.Add(".bmp");

            jpgHandler.SonrakiHandler = pngHandler;

            pngHandler.SonrakiHandler = bmpHandler;

            comboBox1.DataSource = formatlar;
        }

        private void albumSecButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(albumAdTextBox.Text) || (String.IsNullOrEmpty(albumTarihTextBox.Text) || String.IsNullOrEmpty(albumKonumTextBox.Text)))
            {
                MessageBox.Show("Lütfen tüm kutucukları doldurunuz...");
            }
            else
            {
                secilenAlbum = album.GetChild(albumAdTextBox.Text, albumKonumTextBox.Text, albumTarihTextBox.Text);

                if (secilenAlbum == null)
                {
                    MessageBox.Show("Aradiginiz album bulunamamistir! Lutfen gecerli degerler giriniz...");
                }
                else
                {
                    fotoSecButton.Enabled = true;

                    fotoAdTextBox.Enabled = true;

                    fotoKonumTextBox.Enabled = true;

                    fotoTarihTextBox.Enabled = true;
                }
            }
        }
        private void fotoSecButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fotoAdTextBox.Text) || String.IsNullOrEmpty(fotoTarihTextBox.Text) || String.IsNullOrEmpty(fotoKonumTextBox.Text))
            {
                MessageBox.Show("Lütfen tüm kutucukları doldurunuz...");
            }
            else
            {
                secilenFoto = secilenAlbum.GetChild(fotoAdTextBox.Text, fotoTarihTextBox.Text, fotoKonumTextBox.Text);

                if (secilenFoto == null)
                {
                    MessageBox.Show("Aradiginiz fotograf bulunamamistir! Lutfen gecerli degerler giriniz...");
                }
                else
                {
                    try
                    {
                        FileStream fs = new FileStream(secilenFoto.FotoDizin, FileMode.OpenOrCreate);

                        pictureBox1.Image = System.Drawing.Image.FromStream(fs);

                        fs.Flush();

                        fs.Close();

                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    button1.Enabled = true;

                    comboBox1.Enabled = true;

                    label7.Enabled = true;
                }
            }           
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FotografEklemeFormu form3 = new FotografEklemeFormu(album);
            form3.Show();
            this.Hide();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                jpgHandler.FormatSec(secilenFoto, comboBox1.Text);

                File.Copy(@secilenFoto.FotoDizin, Path.Combine(@secilenFoto.AnaDizin, secilenFoto.Isim + secilenFoto.Uzanti), true);

                File.Delete(@secilenFoto.FotoDizin);

                secilenFoto.FotoDizin = Path.Combine(@secilenFoto.AnaDizin, secilenFoto.Isim + secilenFoto.Uzanti);

                System.Threading.Thread.Sleep(10);

                MessageBox.Show("Convert işlemi başarı ile gerçekleştirildi...");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FotografDuzenlemeFormu form5 = new FotografDuzenlemeFormu(secilenFoto, secilenAlbum, album);
            form5.Show();
            this.Hide();
        }

        private void Islemler_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
 
    }
}
