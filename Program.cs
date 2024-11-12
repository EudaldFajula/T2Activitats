using System;

//Pre: The user needs to enter a number 
namespace FajulaEudaldEXTthree
{
    public class Exercicithree
    {
        public static bool NegativeNumber(int number)
        {
            return number < 0;
        }
        public static void Main()
        {
            const string Msg = "Please write a number: ";
            const string NoNegative = "Is not negative";
            const string Negative = "Is negative";

            int number;

            try
            {
                Console.WriteLine(Msg);
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(NegativeNumber(number) ? Negative : NoNegative);
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
//Post: The user will know if his number is negative or not