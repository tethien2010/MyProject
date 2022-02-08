using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Timer = System.Windows.Forms.Timer;

namespace MyProject.f_Forms
{
    public partial class Flyout_Form : DevExpress.XtraEditors.XtraForm
    {
        Timer t1 = new Timer();
        Timer t2 = new Timer();
        Timer timer1 = new Timer();

        public Flyout_Form(Color a_background, string a_mess)
        {
            InitializeComponent();

            pnBackground.BackColor = a_background;
            lblClose.BackColor = a_background;
            lblMessage.Text = a_mess;
        }

        public void f_ShowForm()
        {

        }

        private void Flyout_Form_Load(object sender, EventArgs e)
        {
            Opacity = 0;

            t1.Interval = 10;
            t1.Tick += new EventHandler(fadeIn);
            t1.Start();

            t2.Interval = 10;

            timer1.Interval = 3000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            f_CloseForm();
        }

        void fadeIn(object sender, EventArgs e)
        {
            try
            {
                if (Opacity >= 1)
                    t1.Stop();
                else
                    Opacity += 0.05;
            }
            catch (Exception)
            {
                
            }
        }

        public void f_CloseForm()
        {
            t2.Tick += new EventHandler(fadeOut);
            t2.Start();
        }

        void fadeOut(object sender, EventArgs e)
        {
            try
            {
                if (Opacity <= 0)
                {
                    t2.Stop();
                    Close();
                }
                else
                    Opacity -= 0.05;
            }
            catch (Exception)
            {
                
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }
    }
}