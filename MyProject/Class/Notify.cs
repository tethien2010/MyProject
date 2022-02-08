using DevExpress.XtraEditors;
using MyProject.f_Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class Notify
    {
        public static XtraForm s_FormMain = new XtraForm();
        public static void f_Notify(string a_Text, bool a_IsSuccess, bool a_IsWarrning = false)
        {
            Color clor = new Color();
            if (a_IsWarrning)
            {
                clor = Color.FromArgb(230, 175, 75);
            }
            else
            {
                if (a_IsSuccess)
                {
                    clor = Color.FromArgb(67, 160, 71);
                }
                else
                {
                    clor = Color.FromArgb(239, 83, 80);
                }
            }

            Flyout_Form form = new Flyout_Form(clor, a_Text);
            form.Location = s_FormMain.Location;
            form.Width = s_FormMain.Width;
            form.Show(s_FormMain);
        }
    }
}
