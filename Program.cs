using System;

//Pre: The user needs to enter a number 
namespace FajulaEudaldEXTfour
{
    public class Exercicifour
    {
        public static void NaturalNumber(int number)
        {
            
            if (number > 0 && number < 100)
            {
                Console.WriteLine("Is correct");
            }
            else
            {
                Console.WriteLine("Is incorrect");
            }
        }
        public static void Main()
        {
            int number;
            const string Msg = "Please write a number that is positive and less than 100: ";
            Console.WriteLine(Msg);
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                NaturalNumber(number);
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
//Post: The user will know if his number is negative or not and if his number is under 100