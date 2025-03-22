using Sistema_Remuneraciones.app.UI.admin;
using Sistema_Remuneraciones.app.UI.employer;
using Sistema_Remuneraciones.app.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Timer = System.Windows.Forms.Timer;

namespace Sistema_Remuneraciones.app.UI
{
    public partial class login_form : Form
    {

        private Timer admin_timer;
        private Timer employer_timer;


        public login_form()
        {
            InitializeComponent();
            admin_timer = new Timer();
            admin_timer.Interval = 5000; // 5 segundos
            admin_timer.Tick += new EventHandler(admin_timer_Tick);

            employer_timer = new Timer();
            employer_timer.Interval = 5000;
            employer_timer.Tick += new EventHandler(employee_timer_Tick);



        }

            private void btn_login_Click(object sender, EventArgs e)
        {
            string username = login_username.Text;
            string passwd = login_passwd.Text;

            string result = AccountTools.login_checker(username, passwd);

            if (result == "admin")
            {

                CustomMessageBox MessageBox = new CustomMessageBox("Cargando Panel Administrativo, por favor espere..", "Panel Administrativo - Sistema Remuneraciones");
                MessageBox.Show();
                AccountTools.StoreToken(username);
                admin_timer.Start();

            } else if (result == "employee")
            {
                CustomMessageBox MessageBox = new CustomMessageBox("Cargando Vista Empleado, por favor espere..", "Calcular Remuneración - Sistema Remuneraciones");
                MessageBox.Show();
                employer_timer.Start();
                AccountTools.StoreToken(username);
                



            } else
            {
                MessageBox.Show("Error en las credenciales, No Existe el empleado en la base de datos.");
            }
        }

        private void admin_timer_Tick(object sender, EventArgs e)
        {

            admin_timer.Stop();
            CustomMessageBox customMessageBox = new CustomMessageBox("", "");
            customMessageBox.Hide();
            Form adminmenu = new admin_menu();
            Hide();
            adminmenu.Show();
        }
        
        private void employee_timer_Tick(object sender, EventArgs e)
        {
            employer_timer.Stop();
            CustomMessageBox customMessageBox = new CustomMessageBox("", "");
            customMessageBox.Hide();
            Form employermenu = new employer_menu();
            Hide();
            employermenu.Show();
        }



    }
}
