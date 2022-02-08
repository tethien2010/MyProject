using System;
using System.Data;
using System.Drawing;
using DAO;
using DTO;
using NLog;

namespace MyProject.f_Forms
{
    public partial class frm_DangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frm_DangNhap()
        {
            InitializeComponent();
            //comboBox1.DataSource = Util.f_GetServerNameSQL();
        }
        private static readonly Logger logger = LogManager.GetLogger("fileLogger");
        public bool IsLoginSuccessfull = false;
        DAO_User dao_user;
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string tendn = txt_TenDangNhap.Text.Trim();
                string matkhau = txt_MatKhau.Text;

                if (string.IsNullOrEmpty(tendn))
                {
                    Utils utils = new Utils();
                    utils.ShowToolTip(txt_TenDangNhap, panel1, "Thông báo", "Tên đăng nhập không được để trống");
                    //MessageBox.Show("Tên đăng nhập không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_TenDangNhap.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(matkhau))
                {
                    Utils utils = new Utils();
                    utils.ShowToolTip(txt_MatKhau, panel1, "Thông báo", "Mật khẩu không được để trống");
                    //MessageBox.Show("Mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_MatKhau.Focus();
                    return;
                }
                DataTable dt = new DataTable();
                dao_user = new DAO_User();
                dt = dao_user.f_Login(tendn, matkhau);
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataSession.UserName = Convert.ToString(dt.Rows[0]["Account"]);
                    DataSession.HoTen = Convert.ToString(dt.Rows[0]["FullName"]);
                    DAO_UserRights dao = new DAO_UserRights();
                    DataSession.g_list_phanquyen = dao.listUserRights(DataSession.UserName);
                    IsLoginSuccessfull = true;
                    this.Close();
                }
                else
                {
                    DataSession.UserName = "";
                    DataSession.HoTen = "";
                    DataSession.ChucDanh = "";
                    IsLoginSuccessfull = false;
                    Notify.f_Notify("Đăng nhập thất bại!", false);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Lỗi đăng nhập");
            }
        }

        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            
        }
    }
}