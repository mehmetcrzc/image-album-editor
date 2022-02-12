using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public abstract class Component 
    {
        public string Konum { get; set; }

        public string Isim { get; set; }

        public string Tarih { get; set; }

        public string AnaDizin { get; set; }

        public string FotoDizin { get; set; }

        public string Uzanti { get; set; }

        abstract public void AddChild(Component c);

        abstract public void RemoveChild(Component c);

        abstract public string Traverse();

        abstract public Component GetChild(string componentName, string componentDate, string componentLocation);
    }
}
