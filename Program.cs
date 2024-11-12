using System;

//Pre: The user needs to enter a number 
namespace FajulaEudaldEXTfive
{
    public class Exercicifive
    {
        public static void NaturalNumber()
        {
            int number;
            int tries = 3;
            while (tries > 0)
            {
                Console.WriteLine("Please write a number: ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number > 0 && tries > 0)
                {
                    Console.WriteLine("Is correct");
                    tries = tries - 5;
                }
                else
                {
                    Console.WriteLine("Is incorrect");
                    tries--;
                }
            }
            if (tries == 0)
            {
                Console.WriteLine("You dont have more tries");
            }
        }
        public static void Main()
        {
            try
            {
                NaturalNumber();
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
//Post: The user will know if his number is negative or not