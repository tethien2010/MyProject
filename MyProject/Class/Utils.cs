using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraLayout;
using System.Windows.Forms;
using System.Drawing;
using DTO;

namespace MyProject
{
    public class Utils
    {
        public void ShowToolTip(Control textEdit, Panel layout, string title, string body, int duration = 1200)
        {
            var control = layout.Parent;
            Point point = new Point();
            //if (control != null)
            //{
            //    point = Cursor.Position = control.PointToScreen(new Point(20, 10));
            //}
            var toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
            toolTip.IsBalloon = true;
            toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            toolTip.ToolTipTitle = title;
            toolTip.Show(body, layout, textEdit.Location.X, textEdit.Location.Y - 70, duration);
        }
        /// <summary>
        /// Kiểm tra phân quyền của user, gồm 2 tham số
        /// </summary>
        /// <param name="form">Name của form</param>
        /// <param name="chucnang">Tên chức năng muốn kiểm tra</param>
        /// <returns></returns>
        public static Tuple<bool, string> f_CheckPermission(string form, string chucnang)
        {
            bool _Result = false;
            string _msg = "Không có quyền";
            if (DataSession.ChucDanh.Equals("admin"))
            {
                return new Tuple<bool, string>(true,"");
            }
            if (DataSession.g_list_phanquyen != null)
            {
                var Per = DataSession.g_list_phanquyen.Where(p => p.Menu.Equals(form) && p.Account.Equals(DataSession.UserName)).FirstOrDefault();
                if (Per != null)
                {
                    if (chucnang.Equals("Add"))
                    {
                        _Result = Per.AllowAdd;
                        Notify.f_Notify("Bạn không có quyền tạo thông tin này!", false);
                        _msg = "Bạn không có quyền tạo thông tin này!";
                    }
                    if (chucnang.Equals("Edit"))
                    {
                        _Result = Per.AllowEdit;
                        Notify.f_Notify("Bạn không có quyền cập nhật, chỉnh sửa thông tin này!", false);
                        _msg = "Bạn không có quyền cập nhật, chỉnh sửa thông tin này!";
                    }
                    if (chucnang.Equals("Del"))
                    {
                        _Result = Per.AllowDel;
                        Notify.f_Notify("Bạn không có quyền xóa thông tin này!", false);
                        _msg = "Bạn không có quyền xóa thông tin này!";
                    }
                    //Kiểm tra xem có quyền được hiển thị form này ko
                    if (chucnang.Equals("Disable"))
                    {
                        _Result = Per.Disable;
                        Notify.f_Notify("Bạn không có quyền xem thông tin này!", false);
                        _msg = "Bạn không có quyền xem thông tin này!";
                    }
                }
            }
            
            
            return new Tuple<bool, string>(_Result, _msg);

        }
    }
}
