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
using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using System.Drawing.Imaging;
using System.Security.AccessControl;
using System.Security.Principal;

namespace Final
{
    public partial class FotografDuzenlemeFormu : Form
    {
        private Component secilenFoto;

        private Component anaAlbum;

        private Component secilenAlbum;

        private Bitmap editedImage;

        public FotografDuzenlemeFormu(Component secilenFoto, Component secilenAlbum, Component anaAlbum)
        {
            InitializeComponent();

            this.anaAlbum = anaAlbum;

            this.secilenAlbum = secilenAlbum;

            this.secilenFoto = secilenFoto;

            try
            {
                if (File.Exists(secilenFoto.FotoDizin))
                {
                    FileStream fs = new FileStream(secilenFoto.FotoDizin, FileMode.OpenOrCreate);

                    pictureBox1.Image = System.Drawing.Image.FromStream(fs);

                    fs.Flush();

                    fs.Close();

                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    editedImage = (Bitmap)(pictureBox1.Image);
                }
                else
                {
                    MessageBox.Show("Dosya bulunamadi....");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             
        }

        private void blurButton_Click(object sender, EventArgs e)
        {
            Bitmap image = Process((Bitmap)pictureBox1.Image, new GaussianBlur(50));
            pictureBox1.Image = image;
        }

        private void brightButton_Click(object sender, EventArgs e)
        {
            Bitmap image = Process((Bitmap)pictureBox1.Image, new BrightnessCorrection(50));
            pictureBox1.Image = image;
        }

        private void doygunlukButton_Click(object sender, EventArgs e)
        {
            Bitmap image = Process((Bitmap)pictureBox1.Image, new SaturationCorrection(50));
            pictureBox1.Image = image;
        }

        private void rotateButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)pictureBox1.Image;
            image.RotateFlip(RotateFlipType.Rotate90FlipXY);
            pictureBox1.Image = image;
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Image = null;

            try
            {
                secilenAlbum.RemoveChild(secilenFoto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Back();

            MessageBox.Show("Fotograf Silindi...");
        }

        Bitmap Process(Bitmap image, IFilter filter)
        {
            return filter.Apply(image);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = editedImage;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)(pictureBox1.Image);

            try
            {
                File.Delete(@secilenFoto.FotoDizin);

                pictureBox1.Image = null;

                image.Save(@secilenFoto.FotoDizin);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (File.Exists(secilenFoto.FotoDizin))
            {
                FileStream fs = new FileStream(secilenFoto.FotoDizin, FileMode.OpenOrCreate);

                pictureBox1.Image = System.Drawing.Image.FromStream(fs);

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                fs.Flush();

                fs.Close();
            }
            else
            {
                MessageBox.Show("Dosya kayıt edilemedi...");
            }

            editedImage = (Bitmap)(pictureBox1.Image);
        }

        private void backButton_Click(object sender, EventArgs e)
        {      
            Back();
        }

        private void Back()
        {
            Islemler form6 = new Islemler(anaAlbum);
            form6.Show();
            this.Hide();
        }

        private void FotografDuzenlemeFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
