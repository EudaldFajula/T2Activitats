using System;

//Pre: 
namespace FajulaEudaldEXTeight
{
    public class Exercicieight
    {
        public static void ChangeNumbers(ref int number, ref int numberTwo)
        {
            int aux = number;
            number = numberTwo;
            numberTwo = aux;
        }
        public static void Main()
        {
            int number = 4, numberTwo = 5;
            try
            {
                ChangeNumbers(ref number, ref numberTwo);
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
//Post: The numbers are changed