using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.IO;

namespace Final
{
    public class Album : Component
    {
        private ArrayList ComponentList = new ArrayList();

        private string isimler;

        public Album(string anaDizin, string albumAdi, string konum, string tarih)
        {
            FotoDizin = null; 

            Uzanti = null;    

            Isim = albumAdi;

            Konum = konum;

            Tarih = tarih;

            isimler = albumAdi;

            AnaDizin = System.IO.Path.Combine(anaDizin, albumAdi);

            try
            {
                System.IO.Directory.CreateDirectory(AnaDizin); 
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public override void AddChild(Component c)
        {
            try
            {
                ComponentList.Add(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public override Component GetChild(string componentName, string componentDate, string componentLocation) 
        {
            foreach (Component a in ComponentList)
            {
                if (a.Isim.Equals(componentName) || (a.Tarih.Equals(componentDate) && a.Konum.Equals(componentLocation)))
                {
                    return a;
                }
            }

            return null;
        }

        public override void RemoveChild(Component c)
        {
            if (c.FotoDizin != null) 
            {
                try
                {
                    File.Delete(Path.Combine(@c.AnaDizin, c.Isim + c.Uzanti));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            ComponentList.Remove(c);
        }

        public override string Traverse()
        {
            isimler = Isim;

            foreach (Component c in ComponentList) 
            {
                if (c is Album)
                {
                    isimler = isimler + ' ' + c.Traverse();
                }                      
            }
            return isimler;
        }




    }



}
