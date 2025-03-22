using Sistema_Remuneraciones.app.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Remuneraciones.app.utils
{
    public class AccountTools
    {
        public static string CleanRUT(string rut)
        {
            return rut.Replace(".", "").Replace("-", "");
        }

        public static string CleanPhone(string phone)
        {
            return phone.Replace("+", "").Replace("56", "");
        }

        public static void KeyPressRut(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        public static void KeyPressPhone(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '+' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        public static void KeyDownPhone(object sender, KeyEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox.SelectionStart < 4 && (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete))
            {
                e.SuppressKeyPress = true;
            }
        }

        public static void TextChangedRut(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string text = textBox.Text;

            string cleanRut = CleanRUT(text);

            if (cleanRut.Length > 9)
            {
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
                textBox.SelectionStart = textBox.Text.Length;
            }

            if (text.Length > 12 || (text.Contains("-") && text.Length > 10) || (text.Contains(".") && text.Length > 12))
            {
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        public static void TextChangedPhone(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string text = textBox.Text;

            string cleanPhone = text.Replace("+569", "").Replace(" ", "");

            if (cleanPhone.Length > 8)
            {
                cleanPhone = cleanPhone.Substring(0, 8);
            }

            string formattedPhone = "+569" + cleanPhone;

            textBox.Text = formattedPhone;
            textBox.SelectionStart = textBox.Text.Length;
        }

        public static void KeyPressLetters(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back &&
                "áéíóúÁÉÍÓÚ".IndexOf(e.KeyChar) < 0)
            {
                e.Handled = true;
            }
        }

        public static string login_checker(string username, string passwd)
        {
            string adminUser = "Admin";
            string adminPsswd = "admin";
            username = username.ToLower();

            username = CleanRUT(username);

            if (username == adminUser && passwd == adminPsswd)
            {
                return "admin";
            }

            List<Employee> employees = Employee.GetEmployeers();

            foreach (var employee in employees)
            {
                if (employee.RUT.ToString() == username)
                {
                    return "employee";
                }
            }
            return "error";
        }

        // Token System

        private static string _token;

        public static void StoreToken(string token)
        {
            _token = token;
        }

        public static string GetToken()
        {
            return _token;
        }

        public static void DeleteToken()
        {
            _token = null;
        }
    }
}
