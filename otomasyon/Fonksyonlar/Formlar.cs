using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otomasyon.Fonksyonlar
{
    class Formlar
    {
        public void StokListesi(bool Secim = false)
        {
            Modu_Stok.frmStok_Listesi frm = new Modu_Stok.frmStok_Listesi();

            if(Secim)
            {
                frm.secim = Secim;
                frm.ShowDialog();

            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();

            }
        }
        public void StokGruplari(bool Secim = false)
        {
            Modu_Stok.frmStok_Gruplari mdg = new Modu_Stok.frmStok_Gruplari();
            
            if (Secim) mdg.secim = Secim;
            mdg.ShowDialog();


        }
        public void StokHareketler(bool Ac=false)
        {

        }
        public void StokKarti(bool Ac=false)
        {
            Modu_Stok.frmstok_Karti frm = new Modu_Stok.frmstok_Karti();

            frm.ShowDialog();
        }
    }
}
