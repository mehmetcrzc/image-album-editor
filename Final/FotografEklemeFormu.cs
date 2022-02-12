using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class FotografEklemeFormu : Form
    {
        private Component album = null;

        private Component secilenAlbum = null;

        private Factory factory = new Factory();

        private string fotoDizin = null;

        public FotografEklemeFormu(Component album)
        {

            this.album = album;

            InitializeComponent();

            comboBox1.DataSource = IcerikGoruntule(album);
           
        }

        private void fotografEkleButton_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(fotografAdiTextBox.Text) || String.IsNullOrEmpty(fotografTarihiTextBox.Text) || String.IsNullOrEmpty(fotografKonumuTextBox.Text))
            {
                MessageBox.Show("Lütfen tüm kutucukları doldurunuz...");
            }
            else
            {                
                try
                {
                    secilenAlbum = album.GetChild(comboBox1.Text, null, null);

                    secilenAlbum.AddChild(factory.MakeComponent(fotografAdiTextBox.Text, null, fotografKonumuTextBox.Text, fotografTarihiTextBox.Text, secilenAlbum.AnaDizin, fotoDizin));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            fotografAdiTextBox.Clear();

            fotografKonumuTextBox.Clear();
        }

        private List<string> IcerikGoruntule(Component component)
        {
            List<string> icerikler = new List<string>();

            string[] icerikArray = component.Traverse().Split(' ');

            foreach (string icerik in icerikArray)
            {
                icerikler.Add(icerik);
            }

            icerikler.RemoveAt(0);

            return icerikler;
        }

        private void fotografSecButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image File(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *,jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                fotoDizin = open.FileName;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {

            Islemler form2 = new Islemler(album);

            form2.Show();

            this.Hide();
        }

        private void FotografEklemeFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
