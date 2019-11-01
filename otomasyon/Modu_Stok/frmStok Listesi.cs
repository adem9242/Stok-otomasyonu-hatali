using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace otomasyon.Modu_Stok
{
    public partial class frmStok_Listesi : DevExpress.XtraEditors.XtraForm
    {
        public bool secim = false;
        int SecimID=-1;
        bool Edit = false;

        Fonksyonlar.DatabaseDataContext db = new Fonksyonlar.DatabaseDataContext();

        public frmStok_Listesi()
        {
            InitializeComponent();
        }

        private void frmStok_Listesi_Load(object sender, EventArgs e)
        {
            listele();
        }
        void listele()
        {
            var listele = from s in db.TBL_STOKLARs
                          where s.STOKADİ.Contains(txtstadi.Text) && s.STOKKODU.Contains(txtstkodu.Text) && s.BARKOD.Contains(txtbarkod.Text)
                          select s;
            Listem.DataSource = listele;

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            txtbarkod.Text = "";
            txtstadi.Text = "";
            txtstkodu.Text = "";
        }



        void sec()
        {
            try
            {
                Edit = true;
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());

                txtstadi.Text = gridView1.GetFocusedRowCellValue("STOKADI").ToString();
                txtstkodu.Text = gridView1.GetFocusedRowCellValue("STOKADI").ToString();
                txtbarkod.Text = gridView1.GetFocusedRowCellValue("STOKBARKOD").ToString();

            }
            catch (Exception)
            {

                throw;
            }




        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            sec();
            if (secim && SecimID > 0)
                AnaForm.aktarma = SecimID;
            this.Close();
            
        }
    }
}