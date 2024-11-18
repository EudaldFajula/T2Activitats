using System;
using System.Net.NetworkInformation;


//Pre: The user need to enter a decimal number
namespace FajulaEudaldEXTfifteen
{
    public class Exercicififteen
    {
        public static decimal TransformDecimalpart(decimal number)
        {
            int aux = (int)number;
            decimal decimalNum = number - aux;
            return decimalNum;
        }
        public static int TransformEnter(decimal number)
        {
            return ((int)number);
        }
        public static void Main()
        {
            const string Msg = "Introdueix un numero decimal: ";
            const string EnterMsg = "El numero en enter es: {0}";
            const string DecimalMsg = "Els decimals son: {0}";
            decimal number;
            Console.WriteLine(Msg);
            try
            {
                number = Convert.ToDecimal(Console.ReadLine());
                Console .WriteLine(EnterMsg, TransformEnter(number));
                Console.WriteLine(DecimalMsg, TransformDecimalpart(number));
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}   
//Post: The user will know the number he entered the enter part and the decimal part