using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otomasyon.Fonksyonlar
{
    class numara
    {
        DatabaseDataContext DB = new DatabaseDataContext();
        mesajlar mesajlar = new mesajlar();
        public string StokKodNumarasi()
        {

            try
            {
                int numara = int.Parse((from s in DB.TBL_STOKLARs orderby s.ID descending select s).First().STOKKODU);
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;

            }
            catch (Exception)
            {

                return "0000001";
            }

            
        }
    }
}
