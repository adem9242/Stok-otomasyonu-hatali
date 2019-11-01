using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace otomasyon.Modu_Stok
{
    public partial class frmstok_Karti : DevExpress.XtraEditors.XtraForm
    {

        OpenFileDialog Dosya = new OpenFileDialog();
        bool Edit = false;
        bool resimSec = false;
         int GrupİD = -1;
        int Stokid = -1;

        Fonksyonlar.DatabaseDataContext DB = new Fonksyonlar.DatabaseDataContext();
        Fonksyonlar.Formlar form = new Fonksyonlar.Formlar();
        Fonksyonlar.mesajlar mesj = new Fonksyonlar.mesajlar();
        Fonksyonlar.numara nm = new Fonksyonlar.numara();
        Fonksyonlar.resimleme rs = new Fonksyonlar.resimleme();
        public frmstok_Karti()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmstok_Karti_Load(object sender, EventArgs e)
        {
           txtstokkodu.Text= nm.StokKodNumarasi();

        }

        void Resimsec()
        {
            Dosya.Filter = "Jpg(*.jpg)|*.jpg|Jpeg(*.jpeg)|*.jpeg";
            if(Dosya.ShowDialog()==DialogResult.OK)
            {

                txtresimkutus.ImageLocation = Dosya.FileName;
                resimSec = true;

            }


        }



        void temzile()
        {
            txtstokkodu.Text = nm.StokKodNumarasi();
            txtstokadi.Text = "";
            txtgrupkodu.Text = "";
            txtgrupadi.Text = "";
            txtaliskdv.Text = "0";
            txtalisfiyat.Text = "0";
            txtsatisfiyat.Text = "0";
            txtsatiskdv.Text = "0";
            txtbirim.SelectedIndex = 0;
            txtbarkod.Text = "";
            Edit = false;
            resimSec = false;
            GrupİD = -1;
            Stokid = -1;
            AnaForm.aktarma = -1;

        }

        private void btnresim_Click(object sender, EventArgs e)
        {
            Resimsec();
        }
    }
}