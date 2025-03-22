using System;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_Remuneraciones.app.utils
{
    public class FormUtils
    {

        public static void KeyPressWorkHours(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        public static void EnableSpecificControls(Form form, List<string> controlNames)
        {
            foreach (Control control in GetAllControls(form))
            {
                if (controlNames.Contains(control.Name))
                {
                    control.Enabled = true;
                }
            }
        }

            public static void EnableControls(Form form, string prefix)
        {
            foreach (Control control in GetAllControls(form))
            {
                if (control is TextBox || control is Button || control is ComboBox)
                {
                    if (control.Name.StartsWith(prefix))
                    {
                        control.Enabled = true;
                    }
                }
            }
        }

        public static void DisableControls(Form form, string prefix)
        {
            foreach (Control control in GetAllControls(form))
            {
                if (control is TextBox || control is Button || control is ComboBox)
                {
                    if (control.Name.StartsWith(prefix))
                    {
                        control.Enabled = false;
                    }
                }
            }
        }

        public static void DisableSpecificControls(Form form, List<string> controlNames)
        {
            foreach (Control control in GetAllControls(form))
            {
                if (controlNames.Contains(control.Name))
                {
                    control.Enabled = false;
                }
            }
        }

        public static void ClearForm(Form form, string prefix)
        {
            foreach (Control control in GetAllControls(form))
            {
                if (control is TextBox && control.Name.StartsWith(prefix))
                {
                    ((TextBox)control).Clear();
                }
            }
        }

        private static IEnumerable<Control> GetAllControls(Control control)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAllControls(ctrl)).Concat(controls);
        }
    }
}
