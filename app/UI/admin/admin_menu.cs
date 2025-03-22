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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Sistema_Remuneraciones.app.UI.admin
{
    public partial class admin_menu : Form
    {

        List<Panel> panels = new List<Panel>();
        int index;

        public admin_menu()
        {
            InitializeComponent();

            addemployer_firstname.KeyPress += new KeyPressEventHandler(AccountTools.KeyPressLetters);
            addemployer_lastname.KeyPress += new KeyPressEventHandler(AccountTools.KeyPressLetters);
            addemployer_rut.KeyPress += new KeyPressEventHandler(AccountTools.KeyPressRut);
            addemployer_phone.KeyPress += new KeyPressEventHandler(AccountTools.KeyPressPhone);
            addemployer_phone.KeyDown += new KeyEventHandler(AccountTools.KeyDownPhone);
            addemployer_phone.TextChanged += new EventHandler(AccountTools.TextChangedPhone);
            addemployer_rut.TextChanged += new EventHandler(AccountTools.TextChangedRut);

            updateemployer_rut.TextChanged += new EventHandler(AccountTools.TextChangedRut);
            updateemployer_firstname.KeyPress += new KeyPressEventHandler(AccountTools.KeyPressLetters);
            updateemployer_lastname.KeyPress += new KeyPressEventHandler(AccountTools.KeyPressLetters);
            updateemployer_rut.KeyPress += new KeyPressEventHandler(AccountTools.KeyPressRut);
            updateemployer_phone.KeyDown += new KeyEventHandler(AccountTools.KeyDownPhone);
            updateemployer_phone.TextChanged += new EventHandler(AccountTools.TextChangedPhone);
            updateemployer_phone.KeyPress += new KeyPressEventHandler(AccountTools.KeyPressPhone);

            deleteemployer_rut.KeyPress += new KeyPressEventHandler(AccountTools.KeyPressRut);
            deleteemployer_rut.TextChanged += new EventHandler(AccountTools.TextChangedRut);

            calculatesalary_rut.TextChanged += new EventHandler(AccountTools.TextChangedRut);
            calculatesalary_rut.KeyPress += new KeyPressEventHandler(AccountTools.KeyPressRut);
            calculatesalary_workedhours.KeyPress += new KeyPressEventHandler(FormUtils.KeyPressWorkHours);
            calculatesalary_extrahours.KeyPress += new KeyPressEventHandler(FormUtils.KeyPressWorkHours);

        }

        private void showpanel(int index)
        {
            panels[index].BringToFront();
        }

        private void admin_menu_Load(object sender, EventArgs e)
        {
            panels.Add(mainmenu_panel);
            panels.Add(addemployer_panel);
            panels.Add(updateemployer_panel);
            panels.Add(deleteemployer_panel);
            panels.Add(calculatesalary_panel);
            panels.Add(employerslist_panel);
            if (panels.Count > 0)
            {
                panels[index].BringToFront();
            }

            mainmenu_title.Text = mainmenu_title.Text.Replace("{username}", AccountTools.GetToken().ToString());

            showpanel(0);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Estás a punto de cerrar sesión, " +
                "¿Estás seguro?",
                "Panel Administrativo - Sistema Remuneraciones",
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
        private void AddEmployerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtils.ClearForm(this, "addemployer_");
            showpanel(1);
        }

        private void UpdateEmployerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtils.ClearForm(this, "updateemployer_");
            FormUtils.DisableControls(this, "updateemployer_");
            var controlsEnable = new List<string> { "updateemployer_rut", "updateemployer_btnsearch" };
            FormUtils.EnableSpecificControls(this, controlsEnable);
            showpanel(2);

        }

        private void eliminarTrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtils.ClearForm(this, "deleteemployer_");
            FormUtils.DisableControls(this, "deleteemployer_");
            var controlsEnable = new List<string> { "deleteemployer_rut", "deleteemployer_btnsearch" };
            FormUtils.EnableSpecificControls(this, controlsEnable);
            showpanel(3);
        }

        private void CalculateSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtils.DisableControls(this, "calculatesalary_");
            var controlsEnable = new List<string> { "calculatesalary_rut", "calculatesalary_btnsearch" };
            FormUtils.EnableSpecificControls(this, controlsEnable);

            calculatesalary_afp.Items.Clear();
            calculatesalary_health.Items.Clear();
            FormUtils.ClearForm(this, "calculatesalary_");

            string[] AFPList = { "Sin AFP", "Modelo", "Cuprum", "Capital", "ProVida" };
            string[] HealthList = { "Sin Salud", "Fonasa", "Consalud", "MasVida", "BanMedica" };

            calculatesalary_afp.Items.AddRange(AFPList);
            calculatesalary_health.Items.AddRange(HealthList);

            calculatesalary_afp.SelectedIndex = 0;
            calculatesalary_health.SelectedIndex = 0;

            calculatesalary_btnadd.Text = "Añadir Datos";
            calculatesalary_btnadd.AutoSize = true;

            showpanel(4);
        }

        private void EmployersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employerslist_datagrid.CellContentClick += employerslist_datagrid_CellContentClick;
            employerslist_datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            employerslist_datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            employerslist_datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            employerslist_datagrid.Rows.Clear();

            if (employerslist_datagrid.Columns.Count == 0)
            {
                employerslist_datagrid.Columns.Add("RUT", "RUT");
                employerslist_datagrid.Columns.Add("Nombre", "Nombre");
                employerslist_datagrid.Columns.Add("Apellido", "Apellido");
                employerslist_datagrid.Columns.Add("Número De Contacto", "Número de Contacto");
                employerslist_datagrid.Columns.Add("Dirección", "Dirección");
                employerslist_datagrid.Columns.Add("Sueldo Liquido", "Sueldo Liquido");
                employerslist_datagrid.Columns.Add("Sueldo Bruto", "Sueldo Bruto");
                employerslist_datagrid.Columns.Add("AFP", "AFP");
                employerslist_datagrid.Columns.Add("Seguro Salud", "Seguro Salud");
            }
            List<Employee> employers = Employee.GetEmployeers();
            foreach (var i in employers)
            {
                string[] row = new string[]
                {
                    i.RUT.ToString(),
                    i.FirstName.ToString(),
                    i.LastName.ToString(),
                    i.Phone.ToString(),
                    i.Address.ToString(),
                    i.NetSalary.ToString(),
                    i.GrossSalary.ToString(),
                    i.AFP.ToString(),
                    i.Health.ToString()
                };
                employerslist_datagrid.Rows.Add(row);
            }


            showpanel(5);
        }


        private void addemployer_btnadd_Click(object sender, EventArgs e)
        {

            var rut = AccountTools.CleanRUT(addemployer_rut.Text);
            var phone = AccountTools.CleanPhone(addemployer_phone.Text);

            List<string> errors = new List<string>();

            if (string.IsNullOrEmpty(addemployer_firstname.Text))
                errors.Add("El nombre es requerido.");
            if (string.IsNullOrEmpty(addemployer_lastname.Text))
                errors.Add("El apellido es requerido.");
            if (string.IsNullOrEmpty(addemployer_rut.Text))
                errors.Add("El rut no puede estar vacío.");
            if (rut.Length < 8)
                errors.Add("El rut es inválido.");
            if (string.IsNullOrEmpty(addemployer_phone.Text))
                errors.Add("El número de contacto no puede estar vacío.");
            if (phone.Length < 9)
                errors.Add("El número de contacto es inválido");
            if (string.IsNullOrEmpty(addemployer_address.Text))
                errors.Add("La dirección es requerida.");

            if (errors.Any())
            {
                MessageBox.Show(string.Join("\n", errors), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Employee employer = new Employee(addemployer_firstname.Text,
                    addemployer_lastname.Text,
                    Convert.ToInt32(rut),
                    addemployer_address.Text,
                    Convert.ToInt32(phone),
                    0,
                    0,
                    0,
                    0,
                    null,
                    null);
                Employee.SaveEmployee(employer);
                FormUtils.ClearForm(this, "addemployer_");
                MessageBox.Show("El Trabajador fue añadido con exito.");
            }
        }

        private void deleteemployer_btnsearch_Click(object sender, EventArgs e)
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrEmpty(deleteemployer_rut.Text))
                errors.Add("El Rut es necesario para buscar al Trabajador.");
            if (deleteemployer_rut.Text.Length < 8)
                errors.Add("El Rut es inválido.");

            if (errors.Any())
            {
                MessageBox.Show(string.Join("\n", errors), "Errores Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    var rut = AccountTools.CleanRUT(deleteemployer_rut.Text);
                    bool found = false;
                    List<Employee> employer = Employee.GetEmployeers();
                    foreach (var i in employer)
                    {
                        if (i.RUT.ToString() == rut)
                        {
                            found = true;
                            DialogResult result = MessageBox.Show("Trabajador Encontrado, Estás a punto de eliminarlo. " +
                                "¿Estás seguro?",
                                "Panel Administrativo - Sistema Remuneraciones",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                Employee.DeleteEmployee(i);
                                MessageBox.Show("El trabajador se elimino exitosamente del sistema", "Trabajador Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            break;
                        }
                    }
                    if (!found)
                    {
                        throw new Exception("El trabajador no se encuentra en la base de datos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void updateemployer_btnsearch_Click(object sender, EventArgs e)
        {


            var rut = AccountTools.CleanRUT(updateemployer_rut.Text);

            List<string> errors = new List<string>();

            if (string.IsNullOrEmpty(updateemployer_rut.Text))
                errors.Add("El Rut es necesario para buscar al Trabajador.");
            if (rut.Length < 8)
                errors.Add("El Rut es inválido.");

            if (errors.Any())
            {
                MessageBox.Show(string.Join("\n", errors), "Errores Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    bool found = false;
                    List<Employee> employer = Employee.GetEmployeers();
                    foreach (var i in employer)
                    {
                        if (i.RUT.ToString() == rut)
                        {
                            found = true;
                            MessageBox.Show($"Se ha encontrado al trabajador.", "Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FormUtils.EnableControls(this, "updateemployer_");
                            var controlsDisable = new List<string> { "updateemployer_rut", "updateemployer_btnsearch" };
                            FormUtils.DisableSpecificControls(this, controlsDisable);

                            updateemployer_firstname.Text = i.FirstName;
                            updateemployer_lastname.Text = i.LastName;
                            updateemployer_phone.Text = i.Phone.ToString();
                            updateemployer_address.Text = i.Address;

                        }
                        break;
                    }
                    if (!found)
                    {
                        throw new Exception("El Trabajador no se encuentra en la base de datos.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void updateemployer_btnupdate_Click(object sender, EventArgs e)
        {
            var phone = AccountTools.CleanPhone(updateemployer_phone.Text);

            List<string> errors = new List<string>();

            if (string.IsNullOrEmpty(updateemployer_firstname.Text))
                errors.Add("El nombre es requerido.");
            if (string.IsNullOrEmpty(updateemployer_lastname.Text))
                errors.Add("El apellido es requerido.");
            if (string.IsNullOrEmpty(updateemployer_phone.Text))
                errors.Add("El número de contacto no puede estar vacío.");
            if (phone.Length < 9)
                errors.Add("El número de contacto es inválido");
            if (string.IsNullOrEmpty(updateemployer_address.Text))
                errors.Add("La dirección es requerida.");

            if (errors.Any())
            {
                MessageBox.Show(string.Join("\n", errors), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string result = Employee.UpdateEmployerInfo(Convert.ToInt32(updateemployer_rut.Text),
                        updateemployer_firstname.Text,
                        updateemployer_lastname.Text,
                        Convert.ToInt32(phone),
                        updateemployer_address.Text);

                    if (result == "success")
                    {
                        FormUtils.ClearForm(this, "updateemployer_");
                        FormUtils.DisableControls(this, "updateemployer_");
                        var controlsEnable = new List<string> { "updateemployer_rut", "updateemployer_btnsearch" };
                        FormUtils.EnableSpecificControls(this, controlsEnable);
                        MessageBox.Show("Información del trabajador actualizada correctamente.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró al trabajador con el RUT especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al actualizar la información: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void calculatesalary_btnsearch_Click(object sender, EventArgs e)
        {

            var rut = AccountTools.CleanRUT(calculatesalary_rut.Text);

            List<string> errors = new List<string>();

            if (string.IsNullOrEmpty(calculatesalary_rut.Text))
                errors.Add("El Rut es necesario para buscar al Trabajador.");
            if (rut.Length < 8)
                errors.Add("El Rut es inválido.");

            if (errors.Any())
            {
                MessageBox.Show(string.Join("\n", errors), "Errores Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    bool found = false;

                    List<Employee> employer = Employee.GetEmployeers();
                    foreach (var i in employer)
                    {
                        if (i.RUT.ToString() == rut)
                        {

                            found = true;
                            MessageBox.Show($"Se ha encontrado al trabajador.", "Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FormUtils.EnableControls(this, "calculatesalary_");
                            var controlsDisable = new List<string> { "calculatesalary_rut", "calculatesalary_btnsearch", "calculatesalary_btnadd" };
                            FormUtils.DisableSpecificControls(this, controlsDisable);

                            calculatesalary_workedhours.Text = i.WorkedHours.ToString();
                            calculatesalary_extrahours.Text = i.ExtraHours.ToString();

                            if (i.WorkedHours > 0 && i.ExtraHours > 0 && i.NetSalary > 0 && i.GrossSalary > 0)
                            {
                                calculatesalary_btnadd.Text = "Actualizar Datos";
                                calculatesalary_btnadd.AutoSize = true;
                            } else
                            {
                                calculatesalary_btnadd.Text = "Añadir Datos";
                                calculatesalary_btnadd.AutoSize = true;
                            }
                            break;
                        }
                    }
                    if (!found)
                    {
                        throw new Exception("El trabajador no se encuentra en la base de datos.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void calculatesalary_btncalculate_Click(object sender, EventArgs e)
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrEmpty(calculatesalary_workedhours.Text))
                errors.Add("Las horas trabajadas son requeridas.");
            if (string.IsNullOrEmpty(calculatesalary_extrahours.Text))
                errors.Add("La horas extra son requeridas, si no tiene horas extra dejar en 0.");
            if (calculatesalary_workedhours.Text == "0")
                errors.Add("Las horas trabajadas no pueden ser menor a 0");
            if (calculatesalary_extrahours.Text == "0")
                errors.Add("Las horas extra no pueden ser menor a 0");

            if (errors.Any())
            {
                MessageBox.Show(string.Join("\n", errors), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (calculatesalary_afp.SelectedIndex == 0)
                    {
                        calculatesalary_afp.SelectedIndex = 1;
                    }
                    if (calculatesalary_health.SelectedIndex == 0)
                    {
                        calculatesalary_health.SelectedIndex = 1;
                    }

                    var Gross_Salary = PartnerRemuneration.GrossSalaryCalculate(Convert.ToDouble(calculatesalary_workedhours.Text), Convert.ToDouble(calculatesalary_extrahours.Text));
                    var AFPDiscount = PartnerRemuneration.AFPDiscount(calculatesalary_afp.SelectedItem.ToString(), Gross_Salary);
                    var HealthDiscount = PartnerRemuneration.HealthDiscountCalculate(calculatesalary_health.SelectedItem.ToString(), Gross_Salary);
                    var NetSalary = PartnerRemuneration.NetSalaryCalculate(Gross_Salary, AFPDiscount, HealthDiscount);

                    calculatesalary_grosssalary.Text = Gross_Salary.ToString();
                    calculatesalary_netsalary.Text = NetSalary.ToString();

                    MessageBox.Show("Se ha calculado con exito los descuentos.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var controlsEnable = new List<string> { "calculatesalary_btnadd", "calculatesalary_btnclear" };
                    FormUtils.DisableControls(this, "calculatesalary_");
                    FormUtils.EnableSpecificControls(this, controlsEnable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"error: {ex.Message}");
                }


            }
        }

        private void calculatesalary_btnadd_Click(object sender, EventArgs e)
        {
            try
            {

                var result = Employee.UpdateEmployerWork(Convert.ToInt32(calculatesalary_rut.Text),
                    Convert.ToDouble(calculatesalary_workedhours.Text),
                    Convert.ToDouble(calculatesalary_extrahours.Text),
                    Convert.ToDouble(calculatesalary_netsalary.Text),
                    Convert.ToDouble(calculatesalary_grosssalary.Text),
                    calculatesalary_afp.SelectedItem.ToString(),
                    calculatesalary_health.SelectedItem.ToString());

                if (result == "success")
                {
                    MessageBox.Show("El Salario del Trabajador se ha añadido correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormUtils.DisableControls(this, "calculatesalary_");
                    var controlenable = new List<string> { "calculatesalary_rut", "calculatesalary_btnsearch" };
                    FormUtils.EnableSpecificControls(this, controlenable);
                    FormUtils.ClearForm(this, "calculatesalary_");
                    calculatesalary_afp.SelectedIndex = 0;
                    calculatesalary_health.SelectedIndex = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void calculatesalary_btnclear_Click(object sender, EventArgs e)
        {
            calculatesalary_afp.SelectedIndex = 0;
            calculatesalary_health.SelectedIndex = 0;
            calculatesalary_workedhours.Clear();
            calculatesalary_extrahours.Clear();
            calculatesalary_netsalary.Clear();
            calculatesalary_grosssalary.Clear();

            MessageBox.Show($"Se ha limpiado los campos con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormUtils.EnableControls(this, "calculatesalary_");
            var controlsDisable = new List<string> { "calculatesalary_rut", "calculatesalary_btnsearch", "calculatesalary_btnadd" };
            FormUtils.DisableSpecificControls(this, controlsDisable);

        }

        private void employerslist_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

} 