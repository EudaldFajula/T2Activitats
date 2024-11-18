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
            const string Msg = "Enter a number: ";
            int number, numberTwo;
            Console.WriteLine(Msg);
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Msg);
            numberTwo = Convert.ToInt32(Console.ReadLine());
            ChangeNumbers(ref number, ref numberTwo);
        }
    }
}
//Post: The numbers are changed