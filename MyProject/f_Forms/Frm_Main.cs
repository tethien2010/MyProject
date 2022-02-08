using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using DAO;
using Newtonsoft.Json;

namespace MyProject.f_Forms
{
    public partial class Frm_Main : RibbonForm
    {
        public Frm_Main()
        {
            InitializeComponent();
        }
        DTO_Function dto_Func;
        DAO_Functions dao_func;
        public void MoForm(Form a_form)
        {

            if (KiemTraTonTaiForm(a_form))
            {
                a_form.Activate();
                return;
            }

            a_form.MdiParent = this;
            a_form.WindowState = FormWindowState.Maximized;
            a_form.Show();
        }

        bool KiemTraTonTaiForm(Form a_form)
        {

            foreach (Form item in this.MdiChildren)
            {
                if (item.Name == a_form.Name)
                {
                    xtraTabbedMdiManager1.Pages[item].MdiChild.Activate();
                    return true;
                }
            }
            return false;
        }
        private void DongTatCaForm()
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm != Parent)
                {
                    frm.Close();
                }
            }
        }
        void Save_Menu()
        {
            List<DTO_Function> lst_func = new List<DTO_Function>();
            
            foreach (RibbonPage page in ribbonControl1.Pages)
            {
                dto_Func = new DTO_Function();
                dto_Func.Menu = page.Name;
                dto_Func.ParentMenu = null;
                dto_Func.Descriptions = page.Text;
                dto_Func.Applications = "TNP";
                dto_Func.U_Type = "Pages";
                lst_func.Add(dto_Func);
                foreach (RibbonPageGroup pagegroup in page.Groups)
                {
                    dto_Func = new DTO_Function();
                    dto_Func.Menu = pagegroup.Name;
                    dto_Func.ParentMenu = page.Name;
                    dto_Func.Descriptions = pagegroup.Text;
                    dto_Func.Applications = "TNP";
                    dto_Func.U_Type = "Groups";
                    lst_func.Add(dto_Func);
                    foreach (BarItemLink baritemlink in pagegroup.ItemLinks)
                    {
                        dto_Func = new DTO_Function();
                        dto_Func.Menu = baritemlink.Item.Name;
                        dto_Func.ParentMenu = pagegroup.Name;
                        dto_Func.Descriptions = baritemlink.Caption;
                        dto_Func.Applications = "TNP";
                        dto_Func.U_Type = "ItemLinks";
                        lst_func.Add(dto_Func);
                    }
                }
            }
            var jsFunc = JsonConvert.SerializeObject(lst_func);
            dao_func = new DAO_Functions();
            dao_func.f_SaveFunc(jsFunc);
        }
        void LoadUserRights()
        {
            if (DataSession.g_list_phanquyen.Any())
            {
                var pages = DataSession.g_list_phanquyen.Where(p=>p.U_Type.Equals("Pages"));
                var groups = DataSession.g_list_phanquyen.Where(p => p.U_Type.Equals("Groups"));
                var itemlinks = DataSession.g_list_phanquyen.Where(p => p.U_Type.Equals("ItemLinks"));
                foreach (RibbonPage page in ribbonControl1.Pages)
                {
                    foreach (var item in pages)
                    {
                        if (item.Menu == page.Name && item.Disable)
                        {
                            page.Visible = false;
                        }
                    }
                    foreach (RibbonPageGroup pagegroup in page.Groups)
                    {
                        foreach (var item in groups)
                        {
                            if (item.Menu == pagegroup.Name && item.Disable)
                            {
                                pagegroup.Enabled = false;
                            }
                        }
                        foreach (BarItemLink baritemlink in pagegroup.ItemLinks)
                        {
                            foreach (var item in itemlinks)
                            {
                                if (item.Menu == baritemlink.Item.Name && item.Disable)
                                {
                                    baritemlink.Item.Enabled = false;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (RibbonPage page in ribbonControl1.Pages)
                {
                    if (page.Name != "")
                    {
                        page.Visible = false;
                    }
                    foreach (RibbonPageGroup pagegroup in page.Groups)
                    {
                        if (pagegroup.Name != "")
                        {
                            page.Visible = false;
                        }
                        foreach (BarItemLink baritemlink in pagegroup.ItemLinks)
                        {
                            if (baritemlink.Item.Name != "")
                            {
                                baritemlink.Visible = false;
                            }
                        }
                    }
                }
            }
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            //frm_DangNhap frm = new frm_DangNhap();
            //frm.ShowDialog();
            Save_Menu();
            LoadUserRights();
            Notify.s_FormMain = this;
        }

        private void bar_DangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            //DataSession.ChucDanh = DataSession.HoTen = DataSession.UserName = "";
            //DataSession.isLoginSuccessfull = false;
            //DataSession.g_list_phanquyen = null;
            DataSession d = new DataSession();
            DongTatCaForm();
            this.Hide();
            
            frm_DangNhap frm = new frm_DangNhap();
            frm.ShowDialog();
            frm.Dispose();
            if (frm.IsLoginSuccessfull)
            {
                //Frm_Main frm_Main = new Frm_Main();
                //frm_Main.Show();
                this.Show();
            }
        }

        private void bar_QuanLyNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_PhanQuyenNguoiDung frm = new frm_PhanQuyenNguoiDung();
            MoForm(frm);
        }
    }
}
