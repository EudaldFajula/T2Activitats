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
            try
            {
                string romeNum = Console.ReadLine();
                Console.WriteLine(FinalMsg, RomeNumToNum(romeNum));
            }
            catch (FormatException)
            {
                Console.WriteLine(ErrorNoNum);
            }
            // Final Exercici 1
        }
    }
}
//Post: The numbers are changed