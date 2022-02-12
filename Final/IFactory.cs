using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public interface IFactory
    {
        Component MakeComponent(string etiket, string albumAdi, string konum, string tarih, string anaDizin, string fotoDizin);

    }
}
