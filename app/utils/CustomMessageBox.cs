using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Remuneraciones.app.utils
{
    public partial class CustomMessageBox : Form
    {
        private System.Windows.Forms.Timer timer;

        public CustomMessageBox()
        {
            InitializeComponent();
        }

        public CustomMessageBox(string message, string title)
        {
            InitializeComponent();
            lblmessage.Text = message;
            this.CenterToScreen();
            this.Text = title;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000; // 5 segundos
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            this.Close();
        }

    }
}
