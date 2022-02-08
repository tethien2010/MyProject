using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using MyProject.f_Forms;
using System.Globalization;
using System.Threading;

namespace MyProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //initCulturalFormattingChanges();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            // Register the Winter Joy skin.
            System.Reflection.Assembly asm = typeof(WinterJoy).Assembly;
            SkinManager.Default.RegisterAssembly(asm);
            //// Apply the skin.
            //DevExpress.XtraEditors.WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle("Winter Joy");
            frm_DangNhap frmDangNhap = new frm_DangNhap();
            Application.Run(frmDangNhap);
            if (frmDangNhap.IsLoginSuccessfull)
            {
                Application.Run(new Frm_Main());
            }
        }
        /*
            - Thay vì chúng ta đi chỉnh định dạng ngày của người sử dụng, thì không hay, nhiều lúc người dùng vẫn mong muốn định dạng máy tính của họ là MM/dd/yyyy.
            - Hay bất kỳ định dạng nào. Tuy nhiên, chúng ta làm sao để khi mở ứng dụng của mình lên chạy đều thể hiện ở định dạng dd/MM/yyyy thì chúng ta sẽ sử dụng cách dưới đây nhé.
         */
        private static void initCulturalFormattingChanges()
        {
            CultureInfo cultureDefinition = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
            cultureDefinition.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            cultureDefinition.DateTimeFormat.ShortTimePattern = "HH:mm:ss";
            Thread.CurrentThread.CurrentCulture = cultureDefinition;
        }
    }
}
