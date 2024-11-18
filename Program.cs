using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using Microsoft.VisualBasic;

//Pre: The user need to enter how many values want to enter
namespace FajulaEudaldEXTtwelve
{
    public class Exercicitwelve
    {
        public static double CelsiusToFahrenheit(int Celsuis)
        {
            double fahrenheit = (1.8 * Celsuis) + 32;
            return fahrenheit;
        }
        public static void Main()
        {
        
            const string Msg = "Introdueix els graus en la escala Celsius: ";
            const string MsgFahrenheit = "En l'escala Fahrenheit es {0}";
            int Celsius;
            Console.WriteLine(Msg);
            try
            {

                Celsius = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(MsgFahrenheit, CelsiusToFahrenheit(Celsius));
            }
            catch (Exception)
            {
                
            }
        }
    }
}   
//Post: The user will have a list of the values he entered