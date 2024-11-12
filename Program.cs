using System;

//Pre: The user needs to enter a number 
namespace FajulaEudaldEXTsix
{
    public class Exercicisix
    {
        public static void AbsoluteNumber(int number)
        {
            
            if (number < 0)
            {
                Console.WriteLine(number = number * -1);
            }
        }
        public static void Main()
        {
            const string Msg = "Please write a number: ";
            int number;
            Console.WriteLine(Msg);
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                AbsoluteNumber(number);
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
//Post: The user will know see his number in absolute