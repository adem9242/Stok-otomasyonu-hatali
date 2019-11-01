using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Data.Linq;
using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace otomasyon.Modu_Stok
{
    public partial class frmStok_Gruplari : DevExpress.XtraEditors.XtraForm
    {

        Fonksyonlar.DatabaseDataContext DB = new Fonksyonlar.DatabaseDataContext();
       
        Fonksyonlar.mesajlar MESAJ = new Fonksyonlar.mesajlar();
        bool Edit = false;
        int SECİMID = -1;
        public bool secim = false;

        public frmStok_Gruplari()
        {
            InitializeComponent();
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (Edit && SECİMID > 0 && MESAJ.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (Edit & SECİMID > 0 && MESAJ.Sil() == DialogResult.Yes) { Sil(); };
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStok_Gruplari_Load(object sender, EventArgs e)
        {
            listele();
        }

        void listele()
        {
            var list = from s in DB.TBL_STOK_GRUPLARIs
            select s;

            
            
            Liste.DataSource = list;
        }
        void Temizle()
        {
            txtgrupkodu.Text = "";
            txtgrupadi.Text = "";
            listele();
            Edit = false;

        }
        public void YeniKaydet()
        {
            try
            {
                Fonksyonlar.TBL_STOK_GRUPLARI grup = new Fonksyonlar.TBL_STOK_GRUPLARI();
                grup.GRUPADİ = txtgrupadi.Text;
                grup.GRUPKODU = txtgrupkodu.Text;
                grup.GRUPSAVEDATE = DateTime.Now;
                grup.GRUPSAVEUSER = AnaForm.Userid;
                DB.TBL_STOK_GRUPLARIs.InsertOnSubmit(grup);
                DB.SubmitChanges();
                

                
                MESAJ.YeniKayit("Kayıt başarıyla tamamlandı");
                Temizle();
            }
            catch (Exception e)
            {

                MESAJ.Hata(e);
            }
        }

        public void Guncelle()

        {
            try
            {
                Fonksyonlar.TBL_STOK_GRUPLARI GRUP = DB.TBL_STOK_GRUPLARIs.First(s => s.ID == SECİMID);
                GRUP.GRUPKODU = txtgrupkodu.Text;
                GRUP.GRUPADİ = txtgrupadi.Text;
                GRUP.GRUPEDİTUSER = AnaForm.Userid;
                GRUP.GRUPEDİTDATE = DateTime.Now;
                DB.SubmitChanges();
                MESAJ.Guncelle(true);
                Temizle();

            }
            catch (Exception e)
            {

                MESAJ.Hata(e);
            }
            

        }
        public void Sil()
        {
            try
            {
                DB.TBL_STOK_GRUPLARIs.DeleteOnSubmit(DB.TBL_STOK_GRUPLARIs.First(s => s.ID == SECİMID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {

                MESAJ.Hata(e);
            }
            

        }


        public void Sec()
        {

            try
            {
                Edit = true;
                SECİMID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtgrupadi.Text = gridView1.GetFocusedRowCellValue("GRUPADİ").ToString();
                txtgrupkodu.Text =gridView1.GetFocusedRowCellValue("GRUPKODU").ToString();
            }
            catch (Exception)
            {

                Edit=false;
                SECİMID = -1;
            }
            

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if(secim && SECİMID>0)
            {
                AnaForm.aktarma = SECİMID;
                this.Close();

            }
        }
    }
}