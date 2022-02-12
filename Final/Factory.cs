using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class Factory : IFactory
    {
        public Component MakeComponent(string etiket, string isim, string konum, string tarih, string anaDizin, string fotoDizin)
        {   

            if (String.IsNullOrEmpty(etiket))
            {
                return new Album(anaDizin, isim, konum, tarih);               
            }
            else if (String.IsNullOrEmpty(isim))
            {
                return new Fotograf(etiket, konum, tarih, fotoDizin, anaDizin);
            }
            else
            {
                throw new Exception();
            }

        }
    }
}
