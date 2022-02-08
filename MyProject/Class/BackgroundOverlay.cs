using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyProject.Class
{
    public static class BackgroundOverlay
    {
        /// <summary>
        /// Extension method dùng để show Modal cho Form 
        /// var uu = new SubForm ();
        ///uu.ShowModal(this, Color.Orange);
        /// </summary>
        /// <param name="form"></param>
        /// <param name="parentForm"></param>
        /// <param name="colorOverlay"></param>
        public static void ShowModal(this Form form, Form parentForm, Color? colorOverlay = null)
        {
            Form formBackground = new Form();
            try
            {
                formBackground.StartPosition = FormStartPosition.Manual;
                formBackground.FormBorderStyle = FormBorderStyle.None;
                formBackground.Opacity = .50d;
                formBackground.BackColor = colorOverlay ?? Color.Black;
                formBackground.WindowState = FormWindowState.Maximized;
                formBackground.TopMost = true;
                formBackground.Location = parentForm.Location;
                formBackground.ShowInTaskbar = false;
                formBackground.Show();
                form.Owner = formBackground;
                form.ShowDialog();
                formBackground.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }
    }
}
