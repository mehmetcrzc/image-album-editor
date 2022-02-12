using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Final
{
    public abstract class FormatHandler 
    {
        protected FormatHandler sonrakiHandler;

        public FormatHandler SonrakiHandler { set { sonrakiHandler = value; } }  

        public abstract void FormatSec(Component secilenFoto, string format);
    }

    public class ConcreteHandlerJpg : FormatHandler
    {
        public override void FormatSec(Component secilenFoto, string format)
        {
            if (format.Equals(".jpg"))
            {
                secilenFoto.Uzanti = ".jpg";
            }
            else
            {
                if (sonrakiHandler != null)
                {
                    sonrakiHandler.FormatSec(secilenFoto, format);
                }
            }
        }
    }

    public class ConcreteHandlerPng : FormatHandler
    {
        public override void FormatSec(Component secilenFoto, string format)
        {
            if(format.Equals(".png"))
            {
                secilenFoto.Uzanti = ".png";    
            }
            else
            {
                if (sonrakiHandler != null)
                {
                    sonrakiHandler.FormatSec(secilenFoto, format);
                }
            }

        }
    }
    public class ConcreteHandlerBmp : FormatHandler
    {
        public override void FormatSec(Component secilenFoto, string format)
        {
            if (format.Equals(".bmp"))
            {
                secilenFoto.Uzanti = ".bmp"; 
            }
            else
            {
                MessageBox.Show("Geçersiz dosya formati...");
            }

        }
    }
}
