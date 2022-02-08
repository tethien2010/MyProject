namespace MyProject.f_Forms
{
    partial class frm_PhanQuyenNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PhanQuyenNguoiDung));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gc_TaiKhoan = new DevExpress.XtraGrid.GridControl();
            this.gv_TaiKhoan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cTenTaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.tls_DanhMucChucNang = new DevExpress.XtraTreeList.TreeList();
            this.cDescription = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.col_DanhMuc = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.col_AllowAdd = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.col_AllowEdit = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.col_AllowDel = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.col_Disable = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.cAccount = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.cParentMenu = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.cFormName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.rep_FormName = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rep_FormName2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbb_Forms = new System.Windows.Forms.ComboBox();
            this.btn_LamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Luu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_TaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tls_DanhMucChucNang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_FormName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_FormName2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gc_TaiKhoan);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(250, 723);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tìn người dùng";
            // 
            // gc_TaiKhoan
            // 
            this.gc_TaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_TaiKhoan.Location = new System.Drawing.Point(2, 28);
            this.gc_TaiKhoan.MainView = this.gv_TaiKhoan;
            this.gc_TaiKhoan.Name = "gc_TaiKhoan";
            this.gc_TaiKhoan.Size = new System.Drawing.Size(246, 693);
            this.gc_TaiKhoan.TabIndex = 0;
            this.gc_TaiKhoan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_TaiKhoan});
            // 
            // gv_TaiKhoan
            // 
            this.gv_TaiKhoan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cTenTaiKhoan,
            this.cHoTen});
            this.gv_TaiKhoan.GridControl = this.gc_TaiKhoan;
            this.gv_TaiKhoan.Name = "gv_TaiKhoan";
            this.gv_TaiKhoan.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_TaiKhoan_FocusedRowChanged);
            // 
            // cTenTaiKhoan
            // 
            this.cTenTaiKhoan.Caption = "Tên tài khoản";
            this.cTenTaiKhoan.FieldName = "Account";
            this.cTenTaiKhoan.MinWidth = 25;
            this.cTenTaiKhoan.Name = "cTenTaiKhoan";
            this.cTenTaiKhoan.Visible = true;
            this.cTenTaiKhoan.VisibleIndex = 0;
            this.cTenTaiKhoan.Width = 94;
            // 
            // cHoTen
            // 
            this.cHoTen.Caption = "Họ tên";
            this.cHoTen.FieldName = "FullName";
            this.cHoTen.MinWidth = 25;
            this.cHoTen.Name = "cHoTen";
            this.cHoTen.Visible = true;
            this.cHoTen.VisibleIndex = 1;
            this.cHoTen.Width = 94;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.panelControl2);
            this.groupControl2.Controls.Add(this.panelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(250, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1015, 723);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Chức năng";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.tls_DanhMucChucNang);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 28);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1011, 641);
            this.panelControl2.TabIndex = 1;
            // 
            // tls_DanhMucChucNang
            // 
            this.tls_DanhMucChucNang.CaptionHeight = 2;
            this.tls_DanhMucChucNang.ColumnPanelRowHeight = 2;
            this.tls_DanhMucChucNang.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.cDescription,
            this.col_DanhMuc,
            this.col_AllowAdd,
            this.col_AllowEdit,
            this.col_AllowDel,
            this.col_Disable,
            this.cAccount,
            this.cParentMenu,
            this.cFormName});
            this.tls_DanhMucChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tls_DanhMucChucNang.KeyFieldName = "Menu";
            this.tls_DanhMucChucNang.Location = new System.Drawing.Point(2, 2);
            this.tls_DanhMucChucNang.Name = "tls_DanhMucChucNang";
            this.tls_DanhMucChucNang.OptionsBehavior.PopulateServiceColumns = true;
            this.tls_DanhMucChucNang.ParentFieldName = "ParentMenu";
            this.tls_DanhMucChucNang.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rep_FormName,
            this.rep_FormName2});
            this.tls_DanhMucChucNang.Size = new System.Drawing.Size(1007, 637);
            this.tls_DanhMucChucNang.TabIndex = 1;
            this.tls_DanhMucChucNang.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.tls_DanhMucChucNang_CustomDrawNodeCell);
            this.tls_DanhMucChucNang.CellValueChanging += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.tls_DanhMucChucNang_CellValueChanging);
            // 
            // cDescription
            // 
            this.cDescription.Caption = "Danh mục";
            this.cDescription.FieldName = "Description";
            this.cDescription.Name = "cDescription";
            this.cDescription.Visible = true;
            this.cDescription.VisibleIndex = 0;
            this.cDescription.Width = 273;
            // 
            // col_DanhMuc
            // 
            this.col_DanhMuc.Caption = "Danh mục";
            this.col_DanhMuc.FieldName = "Menu";
            this.col_DanhMuc.Name = "col_DanhMuc";
            // 
            // col_AllowAdd
            // 
            this.col_AllowAdd.AppearanceHeader.Options.UseTextOptions = true;
            this.col_AllowAdd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_AllowAdd.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col_AllowAdd.Caption = "Thêm";
            this.col_AllowAdd.FieldName = "AllowAdd";
            this.col_AllowAdd.Name = "col_AllowAdd";
            this.col_AllowAdd.Visible = true;
            this.col_AllowAdd.VisibleIndex = 2;
            this.col_AllowAdd.Width = 72;
            // 
            // col_AllowEdit
            // 
            this.col_AllowEdit.AppearanceHeader.Options.UseTextOptions = true;
            this.col_AllowEdit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_AllowEdit.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col_AllowEdit.Caption = "Sửa";
            this.col_AllowEdit.FieldName = "AllowEdit";
            this.col_AllowEdit.Name = "col_AllowEdit";
            this.col_AllowEdit.Visible = true;
            this.col_AllowEdit.VisibleIndex = 3;
            this.col_AllowEdit.Width = 64;
            // 
            // col_AllowDel
            // 
            this.col_AllowDel.AppearanceHeader.Options.UseTextOptions = true;
            this.col_AllowDel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_AllowDel.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col_AllowDel.Caption = "Xóa";
            this.col_AllowDel.FieldName = "AllowDel";
            this.col_AllowDel.Name = "col_AllowDel";
            this.col_AllowDel.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.col_AllowDel.Visible = true;
            this.col_AllowDel.VisibleIndex = 4;
            this.col_AllowDel.Width = 65;
            // 
            // col_Disable
            // 
            this.col_Disable.AppearanceHeader.Options.UseTextOptions = true;
            this.col_Disable.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_Disable.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col_Disable.Caption = "Cấm (Disable)";
            this.col_Disable.FieldName = "Disable";
            this.col_Disable.Name = "col_Disable";
            this.col_Disable.Visible = true;
            this.col_Disable.VisibleIndex = 5;
            this.col_Disable.Width = 99;
            // 
            // cAccount
            // 
            this.cAccount.Caption = "Account";
            this.cAccount.FieldName = "Account";
            this.cAccount.Name = "cAccount";
            // 
            // cParentMenu
            // 
            this.cParentMenu.Caption = "ParentMenu";
            this.cParentMenu.FieldName = "ParentMenu";
            this.cParentMenu.Name = "cParentMenu";
            // 
            // cFormName
            // 
            this.cFormName.Caption = "FormName";
            this.cFormName.ColumnEdit = this.rep_FormName;
            this.cFormName.FieldName = "FormName";
            this.cFormName.Name = "cFormName";
            this.cFormName.Visible = true;
            this.cFormName.VisibleIndex = 1;
            this.cFormName.Width = 404;
            // 
            // rep_FormName
            // 
            this.rep_FormName.AutoHeight = false;
            this.rep_FormName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rep_FormName.Name = "rep_FormName";
            this.rep_FormName.PopupView = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // rep_FormName2
            // 
            this.rep_FormName2.AutoHeight = false;
            this.rep_FormName2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rep_FormName2.Name = "rep_FormName2";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbb_Forms);
            this.panelControl1.Controls.Add(this.btn_LamMoi);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.btn_Luu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(2, 669);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1011, 52);
            this.panelControl1.TabIndex = 0;
            // 
            // cbb_Forms
            // 
            this.cbb_Forms.FormattingEnabled = true;
            this.cbb_Forms.Location = new System.Drawing.Point(333, 16);
            this.cbb_Forms.Name = "cbb_Forms";
            this.cbb_Forms.Size = new System.Drawing.Size(140, 24);
            this.cbb_Forms.TabIndex = 1;
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_LamMoi.ImageOptions.Image")));
            this.btn_LamMoi.Location = new System.Drawing.Point(15, 5);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(108, 37);
            this.btn_LamMoi.TabIndex = 0;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(497, 9);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(154, 36);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Xem trước form";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.ImageOptions.Image")));
            this.btn_Luu.Location = new System.Drawing.Point(142, 6);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(111, 36);
            this.btn_Luu.TabIndex = 0;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // frm_PhanQuyenNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 723);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frm_PhanQuyenNguoiDung";
            this.Text = "Phân quyền người dùng";
            this.Load += new System.EventHandler(this.frm_PhanQuyenNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_TaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tls_DanhMucChucNang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_FormName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_FormName2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gc_TaiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_TaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn cTenTaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn cHoTen;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraTreeList.TreeList tls_DanhMucChucNang;
        private DevExpress.XtraTreeList.Columns.TreeListColumn col_DanhMuc;
        private DevExpress.XtraTreeList.Columns.TreeListColumn col_AllowAdd;
        private DevExpress.XtraTreeList.Columns.TreeListColumn col_AllowEdit;
        private DevExpress.XtraTreeList.Columns.TreeListColumn col_AllowDel;
        private DevExpress.XtraTreeList.Columns.TreeListColumn col_Disable;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_LamMoi;
        private DevExpress.XtraEditors.SimpleButton btn_Luu;
        private DevExpress.XtraTreeList.Columns.TreeListColumn cAccount;
        private DevExpress.XtraTreeList.Columns.TreeListColumn cParentMenu;
        private DevExpress.XtraTreeList.Columns.TreeListColumn cDescription;
        private System.Windows.Forms.ComboBox cbb_Forms;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn cFormName;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rep_FormName;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rep_FormName2;
    }
}