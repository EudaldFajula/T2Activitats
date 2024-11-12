using System;

/// Pre: The user needs to enter a number and a number for exponential

namespace FajulaEudaldEXTtwo
{
    public class Exercicitwo
    {
        public static int Exponential(int number, int exponential)
        {

            for (int i = 0; i < exponential - 1; i++)
            {
                number = number * exponential;
            }
            return number;

        }
        public static void Main()
        {
            const string MsgNormalNum = "Please write a number: ";
            const string MsgPowerNum = "Please write a number for exponential: ";
            const string Return = "Your number is: {0}";
            int number;
            int exponential;
            Console.WriteLine(MsgNormalNum);
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(MsgPowerNum);
                exponential = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Return, Exponential(number, exponential));
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
//Post: The user will know the exponential of the number he entered