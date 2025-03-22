using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Remuneraciones.app.utils
{
    public static class PartnerRemuneration
    {
        public static double GrossSalaryCalculate(double WorkedHours, double ExtraHours)
        {
            return (WorkedHours * 5000) + (ExtraHours * 7000);
        }

        public static double AFPDiscount(string afp, double DirtSalary)
        {
            double AFPDiscount = 0;
            switch (afp)
            {
                case "Cuprum":
                    AFPDiscount = DirtSalary * 0.07;
                    break;

                case "Modelo":
                    AFPDiscount = DirtSalary * 0.09;
                    break;

                case "Capital":
                    AFPDiscount = DirtSalary * 0.12;
                    break;

                case "Provida":
                    AFPDiscount = DirtSalary * 0.13;
                    break;

                default:
                    throw new ArgumentException("AFP no válida");
            }
            return AFPDiscount;
        }

        public static double HealthDiscountCalculate(string health, double dirtSalary)
        {
            double HealthDiscount = 0;
            switch (health)
            {
                case "Fonasa":
                    HealthDiscount = dirtSalary * 0.12;
                    break;

                case "Consalud":
                    HealthDiscount = dirtSalary * 0.13;
                    break;

                case "MasVida":
                    HealthDiscount = dirtSalary * 0.14;
                    break;

                case "BanMedica":
                    HealthDiscount = dirtSalary * 0.15;
                    break;

                default:
                    throw new ArgumentException("Red de salud no válida");
            }
            return HealthDiscount;
        }

        public static double NetSalaryCalculate(double dirtSalary, double afpDiscount, double healthDiscount)
        {
            return dirtSalary - afpDiscount - healthDiscount;
        }
    }
}
