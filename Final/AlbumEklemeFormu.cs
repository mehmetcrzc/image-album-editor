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
    public partial class AlbumEklemeFormu : Form
    {
        private string anaDizin = null;

        private Component album = null;

        private Factory factory = new Factory();

        private bool okey = false;

        public AlbumEklemeFormu()
        {
            InitializeComponent();

            albumEkleButton.Enabled = false;

            nextButton.Enabled = false;

            albumTarihiTextBox.Enabled = false;
        }

        private void albumEkleButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(albumAdiTextBox.Text) || String.IsNullOrEmpty(albumTarihiTextBox.Text) || String.IsNullOrEmpty(albumKonumuTextBox.Text))
            {
                MessageBox.Show("Lütfen tüm kutucukları doldurunuz...");
            }
            else
            {              
                album.AddChild(factory.MakeComponent(null, albumAdiTextBox.Text, albumKonumuTextBox.Text, albumTarihiTextBox.Text,  anaDizin, null));
            }

            albumAdiTextBox.Clear(); 
            
            albumKonumuTextBox.Clear();

            nextButton.Enabled = true;
        }

        private void dizinSecButton_Click(object sender, EventArgs e)
        {
            DizinSec();

            dizinSecButton.Enabled = okey;

            albumEkleButton.Enabled = true;

            albumAdiTextBox.Enabled = true;

            albumKonumuTextBox.Enabled = true;

            albumTarihiTextBox.Enabled = true;
        }

        public void DizinSec()
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();

            if (fdb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                anaDizin = fdb.SelectedPath;
            }
            try
            {
                album = factory.MakeComponent(null, "Albumler", null, null, anaDizin, null);
                anaDizin = album.AnaDizin;
            }
            catch (Exception ex)
            {
                okey = true;
                MessageBox.Show(ex.Message + " lutfen anadizin seçiniz.");
            }         
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            FotografEklemeFormu form1 = new FotografEklemeFormu(album);

            form1.Show();

            this.Hide();
        }
    }
}
