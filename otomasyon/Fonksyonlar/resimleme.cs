using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otomasyon.Fonksyonlar
{
    class resimleme
    {
        public byte[] Resimyukleme(System.Drawing.Image Resim)
        {

            using (MemoryStream ms = new MemoryStream())
            {
                Resim.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();


            }
        }

        public Image ResimGetirme(Byte[] GelenbyteArray)
        {

            using (MemoryStream mg = new MemoryStream(GelenbyteArray))
            {
                Image gelenresim = Image.FromStream(mg);
                return gelenresim;


            }

        }
    }
}
