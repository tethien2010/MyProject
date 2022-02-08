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
using DAO;
using DTO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Skins;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Columns;
using Newtonsoft.Json;
using System.Reflection;
using MyProject.Class;
using NLog;

namespace MyProject.f_Forms
{
    public partial class frm_PhanQuyenNguoiDung : XtraForm
    {
        public frm_PhanQuyenNguoiDung()
        {
            InitializeComponent();
            var skin = GridSkins.GetSkin(tls_DanhMucChucNang.LookAndFeel);
            skin.Properties[GridSkins.OptShowTreeLine] = true;
            tls_DanhMucChucNang.CellValueChanging += tls_DanhMucChucNang_CellValueChanging;
        }
        private static readonly Logger logger = LogManager.GetLogger("fileLogger");

        DAO_UserRights dAO_UserRights;
        BindingList<DTO_UserRights> list_userrights = new BindingList<DTO_UserRights>();
        BindingList<DTO_User> dto_user;
        private void frm_PhanQuyenNguoiDung_Load(object sender, EventArgs e)
        {
            try
            {
                GridViewEdit grid = new GridViewEdit(gv_TaiKhoan);
                DAO_User dao = new DAO_User();
                gc_TaiKhoan.DataSource = dao.GetAll();
                f_LoadFormName();
                if (dto_user == null)
                {
                    dto_user = new BindingList<DTO_User>();
                }
                if (dto_user.Count() == 0)
                {
                    MessageBox.Show("Không có full name", "Thông báo");
                }    
                if (!dto_user.Any())
                {
                    MessageBox.Show("Không có gì hết","Thông báo");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Lỗi load phân quyền người dùng");
            }

        }
        private void gv_TaiKhoan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                var user = Convert.ToString(gv_TaiKhoan.GetFocusedRowCellValue(cTenTaiKhoan));
                list_userrights = new BindingList<DTO_UserRights>();
                dAO_UserRights = new DAO_UserRights();
                list_userrights = dAO_UserRights.listUserRights(user);
                var a = list_userrights.SetValue(x => x.Account = user);
                tls_DanhMucChucNang.DataSource = list_userrights;
                tls_DanhMucChucNang.ExpandAll();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Lỗi click tài khoản");
            }
        }
        private void gv_TaiKhoan_MouseWheel(object sender, MouseEventArgs e)
        {
            if ((sender as GridView).IsEditing)
            {
                (sender as GridView).CloseEditor();
                (sender as GridView).UpdateCurrentRow();
            }
        }
        #region ==Treelis==
        private void tls_DanhMucChucNang_CustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e)
        {
            if (e.Node.HasChildren)
            {
                e.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
                e.Appearance.Options.UseTextOptions = true;
            }
        }

        private void tls_DanhMucChucNang_CellValueChanging(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            e.Node.SetValue(e.Column, e.Value);

        }

        #endregion
        #region ==Set check child and parent==
        private void SetCheckChildNodes(TreeListNode node, TreeListColumn col, bool check)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                node.Nodes[i][col] = check;
                SetCheckChildNodes(node.Nodes[i], col, check);
            }
        }
        private void SetCheckParentNodes(TreeListNode node, TreeListColumn col, bool check)
        {
            if (node.ParentNode != null)
            {
                bool b = false;
                for (int i = 0; i < node.ParentNode.Nodes.Count; i++)
                {
                    var state = (bool)node.ParentNode.Nodes[i][col];
                    if (!check.Equals(state))
                    {
                        b = true;
                        break;
                    }
                    bool bb = !b && check;
                    node.ParentNode[col] = bb;
                    SetCheckChildNodes(node.ParentNode, col, check);
                }
            }
        }
        #endregion

        void f_LoadFormName()
        {
            
            List<AppForm> listapp = new List<AppForm>();
            listapp.Add(new AppForm()
            {
                Id = "",
                FormName = ""
            });
            Type formtype = typeof(Form);
            foreach (Type t in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (formtype.IsAssignableFrom(t))
                {
                    string formtext = "";
                    if (!t.Name.Equals("Flyout_Form"))
                    {
                        try
                        {
                            XtraForm frm = Activator.CreateInstance(t) as XtraForm;

                            if (frm != null)
                            {
                                formtext = frm.Text;
                            }
                        }
                        catch (Exception ex)
                        {
                            //Logger logger = LogManager.GetLogger("fileLogger");
                            logger.Error(ex, $"Lỗi chưa xác định!");
                        }
                        
                    }
                    listapp.Add(new AppForm()
                    {
                        Id = t.Name,
                        FormName = $"{t.Name} - {formtext}"//t.Name
                    }
                    ) ;
                }
            }
            cbb_Forms.DataSource = listapp;
            cbb_Forms.ValueMember = "Id";
            cbb_Forms.DisplayMember = "FormName";

            rep_FormName.DataSource = listapp;
            rep_FormName.ValueMember = "Id";
            rep_FormName.DisplayMember = "FormName";
        }
        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            frm_PhanQuyenNguoiDung_Load(sender, e);
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            var _permission= Utils.f_CheckPermission(this.Name, Consts.Add);
            if (!_permission.Item1)
            {
                Notify.f_Notify(_permission.Item2, _permission.Item1);
                return;
            }
            var user = gv_TaiKhoan.GetFocusedRowCellValue(cTenTaiKhoan);

            var jsUserrigt = JsonConvert.SerializeObject(list_userrights);
            var _save = dAO_UserRights.f_SaveFuncUser(jsUserrigt);
            Notify.f_Notify(_save.Item2, _save.Item1);
            if (_save.Item1)
            {
                if (list_userrights.Any(p => p.Account.Equals(DataSession.UserName)))
                {
                    DataSession.g_list_phanquyen.Clear();
                    DataSession.g_list_phanquyen = list_userrights;
                }
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AppForm obj = cbb_Forms.SelectedItem as AppForm;
            if (obj != null)
            {
                Type t = Type.GetType(obj.Id);
                if (t != null)
                {
                    XtraForm frm = Activator.CreateInstance(t) as XtraForm;
                    if (frm != null)
                    {
                        frm.ShowDialog();
                    }
                }
            }
        }
    }
    public class GridViewEdit
    {

        GridView grid;
        public GridViewEdit() { }
        public GridViewEdit(GridView grid)
        {
            this.grid = grid;
            cells = new List<string>();
            grid.CellValueChanged += gridView_CellValueChanged;
            grid.RowCellStyle += gridView1_RowCellStyle;
            grid.MouseWheel += GridView_MouseWheel;
        }


        #region "Thay đôi màu sắc khi chỉnh sửa giá trị ô"
        List<string> cells;

        public GridView Grid
        {
            get
            {
                return grid;
            }

            set
            {
                grid = value;
            }
        }

        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            string key = e.Column.FieldName + ";" + e.RowHandle.ToString();
            if (!cells.Contains(key))
                cells.Add(key);
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            string key = e.Column.FieldName + ";" + e.RowHandle.ToString();
            if (cells.Contains(key))
                e.Appearance.BackColor = Color.Aquamarine;
            else
                e.Appearance.BackColor = Color.White;
        }

        private void GridView_MouseWheel(object sender, MouseEventArgs e)
        {
            if ((sender as GridView).IsEditing)
            {
                (sender as GridView).CloseEditor();
                (sender as GridView).UpdateCurrentRow();
            }
        }
        #endregion


    }

}