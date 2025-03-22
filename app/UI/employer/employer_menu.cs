using Sistema_Remuneraciones.app.models;
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
using Timer = System.Windows.Forms.Timer;

namespace Sistema_Remuneraciones.app.UI.employer
{
    public partial class employer_menu : Form
    {

        private Timer employer_timer;

        public employer_menu()
        {
            InitializeComponent();

            employer_timer = new Timer();
            employer_timer.Interval = 2000;
            employer_timer.Tick += new EventHandler(employee_timer_Tick);

        }

        string token = AccountTools.GetToken();
        string netsalary;

        private void employer_menu_Load(object sender, EventArgs e)
        {
            List<string> employerDetails = Employee.GetByRut(Convert.ToInt32(token));

            if (employerDetails.Count == 1 && employerDetails[0].StartsWith("Error"))
            {
                MessageBox.Show("Este Trabajador no existe", "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Hide();
                Form login = new login_form();
                login.Show();
                Close();
                return;
            }

            myinfo_rut.Text = employerDetails[0];
            myinfo_name.Text = employerDetails[1] + " " + employerDetails[2];
            myinfo_phone.Text = employerDetails[3];
            myinfo_address.Text = employerDetails[4];
            myinfo_workedhours.Text = myinfo_workedhours.Text.Replace("{workedhours}", employerDetails[8]);
            myinfo_extrahourslabel.Text = myinfo_extrahourslabel.Text.Replace("{extrahours}", employerDetails[7]);
            myinfo_grosssalarylabel.Text = myinfo_grosssalarylabel.Text.Replace("{0}", employerDetails[6]);
            myinfo_afp.Text = employerDetails[9];
            myinfo_health.Text = employerDetails[10];

            netsalary = employerDetails[5];

        }

        private void myinfo_btncalculate_Click(object sender, EventArgs e)
        {

            myinfo_netsalary.Clear();
            CustomMessageBox MessageBox = new CustomMessageBox("Haciendo Calculos del salario Liquido, por favor espere..", "Calcular Remuneración -  Sistema Remuneraciones");
            MessageBox.Show();
            employer_timer.Start();
        }

        private void employee_timer_Tick(object sender, EventArgs e)
        {
            employer_timer.Stop();
            CustomMessageBox customMessageBox = new CustomMessageBox("", "");
            customMessageBox.Hide();
            myinfo_netsalary.Text = netsalary;
        }

        private void myinfo_btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Estás a punto de cerrar sesión, " +
                "¿Estás seguro?",
                "Vista Trabajador - Sistema Remuneraciones",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form login_form = new login_form();
                this.Close();
                AccountTools.DeleteToken();
                login_form.Show();
            }
        }
    }
}
