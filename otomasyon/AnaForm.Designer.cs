namespace otomasyon
{
    partial class AnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonStokkarti = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonStokListesi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonStokGrupları = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonStokHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonStokkarti,
            this.barButtonStokListesi,
            this.barButtonStokGrupları,
            this.barButtonStokHareketleri});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1108, 178);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // barButtonStokkarti
            // 
            this.barButtonStokkarti.Caption = "Stok Kartı";
            this.barButtonStokkarti.Id = 1;
            this.barButtonStokkarti.ImageOptions.LargeImage = global::otomasyon.Properties.Resources.Stok_Kartı32x32;
            this.barButtonStokkarti.Name = "barButtonStokkarti";
            this.barButtonStokkarti.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonStokkarti_ItemClick);
            // 
            // barButtonStokListesi
            // 
            this.barButtonStokListesi.Caption = "Stok Listesi";
            this.barButtonStokListesi.Id = 2;
            this.barButtonStokListesi.ImageOptions.LargeImage = global::otomasyon.Properties.Resources.Stok_Liste32x32;
            this.barButtonStokListesi.Name = "barButtonStokListesi";
            this.barButtonStokListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonStokListesi_ItemClick);
            // 
            // barButtonStokGrupları
            // 
            this.barButtonStokGrupları.Caption = "Stok Grupları";
            this.barButtonStokGrupları.Id = 3;
            this.barButtonStokGrupları.ImageOptions.LargeImage = global::otomasyon.Properties.Resources.Stok_Grup32x32;
            this.barButtonStokGrupları.Name = "barButtonStokGrupları";
            this.barButtonStokGrupları.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonStokGrupları_ItemClick);
            // 
            // barButtonStokHareketleri
            // 
            this.barButtonStokHareketleri.Caption = "Stok Hareketleri";
            this.barButtonStokHareketleri.Id = 4;
            this.barButtonStokHareketleri.ImageOptions.LargeImage = global::otomasyon.Properties.Resources.Stok_Hareket32x32;
            this.barButtonStokHareketleri.Name = "barButtonStokHareketleri";
            this.barButtonStokHareketleri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonStokHareketleri_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonStokkarti);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonStokListesi);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonStokGrupları);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonStokHareketleri);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Stok İşlemleri";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 412);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1108, 37);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2});
            this.ribbonPageCategory1.Text = "ribbonPageCategory1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "AnaForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonStokkarti;
        private DevExpress.XtraBars.BarButtonItem barButtonStokListesi;
        private DevExpress.XtraBars.BarButtonItem barButtonStokGrupları;
        private DevExpress.XtraBars.BarButtonItem barButtonStokHareketleri;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}