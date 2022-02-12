using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Final
{
    public class Fotograf : Component
    {
        public Fotograf(string etiket, string konum, string tarih, string fotoDizin, string anaDizin)
        {
            FotoDizin = fotoDizin;

            Uzanti = ".png"; 

            AnaDizin = anaDizin;

            Isim = etiket;

            Konum = konum;

            Tarih = tarih;

            try 
            { 
                File.Copy(FotoDizin, Path.Combine(@AnaDizin, Isim + Uzanti), true); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            FotoDizin = Path.Combine(@AnaDizin, Isim + Uzanti); 
        }

        public override void AddChild(Component c)
        {
            //Empty method.
        }

        public override Component GetChild(string componentName, string componentDate, string componentLocation)
        {
            //Empty method.
            return null;
        }


        public override void RemoveChild(Component c)
        {
            //Empty method.
        }

        public override string Traverse()
        {
            return Isim;
        }






    }
}
