using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Remuneraciones.app.models
{
    public class Employee
    {
        // Personal Information
        public string FirstName {  get; set; }
        public string LastName {  get; set; }
        public int RUT { get; set; }
        public string Address {  get; set; }

        public int Phone {  get; set; }

        // Salary Info

        public double NetSalary { get; set; }
        public double GrossSalary {  get; set; }


        // Work Info
        public double WorkedHours {  get; set; }
        public double ExtraHours {  get; set; }
        public string AFP {  get; set; }
        public string Health {  get; set; }


        private static List<Employee> employees = new List<Employee>();


        public Employee(string firstName, string lastName, int rut, string address, int phone, double workedHours, double extraHours, double netSalary, double grossSalary, string afp, string health)
        {
            FirstName = firstName;
            LastName = lastName;
            RUT = rut;
            Address = address;
            Phone = phone;

            WorkedHours = workedHours;
            ExtraHours = extraHours;

            NetSalary = netSalary;
            GrossSalary = grossSalary;

            AFP = afp;
            Health = health;

        }


        // Update, Save, Delete and Get Methods
        public static void SaveEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public static void DeleteEmployee(Employee employee)
        {
            employees.Remove(employee);
        }


        public static List<Employee> GetEmployeers() 
        {
            return new List<Employee>(employees);
        }

        public static string UpdateEmployerInfo(int rut, string firstname, string lastname, int phone, string address)
        {
            List<Employee> employees = GetEmployeers();

            Employee? employee = employees.FirstOrDefault(t => t.RUT == rut);
            if (employee != null)
            {
                employee.FirstName = firstname;
                employee.LastName = lastname;
                employee.Phone = phone;
                employee.Address = address;

                return "success";
            }
            else
            {
                return "error";
            }
        }

        public static string UpdateEmployerWork(int rut, double workedHours, double extraHours, double netSalary, double grossSalary, string AFP, string Health)
        {
            List<Employee> employees = GetEmployeers();

            Employee? employee = employees.FirstOrDefault(t => t.RUT == rut);

            if (employee != null)
            {
                employee.WorkedHours = workedHours;
                employee.ExtraHours = extraHours;
                employee.NetSalary = netSalary;
                employee.GrossSalary = grossSalary;
                employee.AFP = AFP;
                employee.Health = Health;

                return "success";
            } else
            {
                throw new ArgumentException("No Existe el trabajador.");
            }
        }

        public static List<string> GetByRut(int rut)
        {
            List<Employee> employees = GetEmployeers();

            Employee? employee = employees.FirstOrDefault(t => t.RUT == rut);
            if (employee != null)
            {
                var employer = new List<string>
                {
                    employee.RUT.ToString(),
                    employee.FirstName.ToString(),
                    employee.LastName.ToString(),
                    employee.Phone.ToString(),
                    employee.Address.ToString(),
                    employee.NetSalary.ToString(),
                    employee.GrossSalary.ToString(),
                    employee.ExtraHours.ToString(),
                    employee.WorkedHours.ToString(),
                    employee.AFP.ToString(),
                    employee.Health.ToString()
                };

                return employer;
            }
            return new List<string> { "Error: Trabajador no encontrado." };
        }



    }
}
