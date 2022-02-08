namespace MyProject.f_Forms
{
    partial class Frm_Main
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
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup3 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.bar_Exit = new DevExpress.XtraBars.BarButtonItem();
            this.bar_DangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.bar_QuanLyNguoiDung = new DevExpress.XtraBars.BarButtonItem();
            this.bar_DoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.bar_LichSuLamViec = new DevExpress.XtraBars.BarButtonItem();
            this.bar_KhoHangHoa = new DevExpress.XtraBars.BarButtonItem();
            this.bar_HangHoa = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.galleryDropDown1 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.ribbonGalleryBarItem1,
            this.bar_Exit,
            this.bar_DangXuat,
            this.bar_QuanLyNguoiDung,
            this.bar_DoiMatKhau,
            this.bar_LichSuLamViec,
            this.bar_KhoHangHoa,
            this.bar_HangHoa,
            this.skinRibbonGalleryBarItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ribbonControl1.MaxItemId = 13;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 424;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1603, 231);
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "InplaceGallery1";
            // 
            // 
            // 
            galleryItemGroup3.Caption = "Group1";
            this.ribbonGalleryBarItem1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup3});
            this.ribbonGalleryBarItem1.Id = 2;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // bar_Exit
            // 
            this.bar_Exit.Caption = "Thoát chương trình";
            this.bar_Exit.Id = 5;
            this.bar_Exit.Name = "bar_Exit";
            // 
            // bar_DangXuat
            // 
            this.bar_DangXuat.Caption = "Đăng xuất";
            this.bar_DangXuat.Id = 6;
            this.bar_DangXuat.Name = "bar_DangXuat";
            this.bar_DangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_DangXuat_ItemClick);
            // 
            // bar_QuanLyNguoiDung
            // 
            this.bar_QuanLyNguoiDung.Caption = "Quản lý người dùng";
            this.bar_QuanLyNguoiDung.Id = 7;
            this.bar_QuanLyNguoiDung.Name = "bar_QuanLyNguoiDung";
            this.bar_QuanLyNguoiDung.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_QuanLyNguoiDung_ItemClick);
            // 
            // bar_DoiMatKhau
            // 
            this.bar_DoiMatKhau.Caption = "Đổi mật khẩu";
            this.bar_DoiMatKhau.Id = 8;
            this.bar_DoiMatKhau.Name = "bar_DoiMatKhau";
            // 
            // bar_LichSuLamViec
            // 
            this.bar_LichSuLamViec.Caption = "Lịch sử làm việc";
            this.bar_LichSuLamViec.Id = 9;
            this.bar_LichSuLamViec.Name = "bar_LichSuLamViec";
            // 
            // bar_KhoHangHoa
            // 
            this.bar_KhoHangHoa.Caption = "Kho hàng hóa";
            this.bar_KhoHangHoa.Id = 10;
            this.bar_KhoHangHoa.Name = "bar_KhoHangHoa";
            // 
            // bar_HangHoa
            // 
            this.bar_HangHoa.Caption = "Hàng hóa /vật tư";
            this.bar_HangHoa.Id = 11;
            this.bar_HangHoa.Name = "bar_HangHoa";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Admin";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Giao diện";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bar_Exit);
            this.ribbonPageGroup2.ItemLinks.Add(this.bar_DangXuat);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Hệ thống";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bar_QuanLyNguoiDung);
            this.ribbonPageGroup3.ItemLinks.Add(this.bar_DoiMatKhau);
            this.ribbonPageGroup3.ItemLinks.Add(this.bar_LichSuLamViec);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Người dùng";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.bar_KhoHangHoa);
            this.ribbonPageGroup4.ItemLinks.Add(this.bar_HangHoa);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Hàng hóa";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.GalleryDropDown = this.galleryDropDown1;
            this.skinRibbonGalleryBarItem1.Id = 12;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // galleryDropDown1
            // 
            this.galleryDropDown1.Name = "galleryDropDown1";
            this.galleryDropDown1.Ribbon = this.ribbonControl1;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 931);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Main";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem bar_Exit;
        private DevExpress.XtraBars.BarButtonItem bar_DangXuat;
        private DevExpress.XtraBars.BarButtonItem bar_QuanLyNguoiDung;
        private DevExpress.XtraBars.BarButtonItem bar_DoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem bar_LichSuLamViec;
        private DevExpress.XtraBars.BarButtonItem bar_KhoHangHoa;
        private DevExpress.XtraBars.BarButtonItem bar_HangHoa;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown1;
    }
}

