using System;


//Pre: The user need to enter two numbers
namespace FajulaEudaldEXTfourteen
{
    public class Exercicifourteen
    {   
        public static bool MaxOrMinim(int number1, int number2)
        {
            return number1 > number2;
        }
        public static void Main()
        {
            const string Msg = "Introdueix un numero: ";
            const string MaxNumMsg = "Max num {0}";
            const string MinNumMsg = "Min num {0}";
            int number1;
            int number2;
            Console.WriteLine(Msg);
            try
            {
                number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Msg);
                number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(MaxNumMsg, MaxOrMinim(number1, number2) ? number1:number2);
                Console.WriteLine(MinNumMsg, MaxOrMinim(number1, number2) ? number2:number1);
            }
            catch (Exception)
            {
                
            }
        }
    }
}   
//Post: The user will know which number is the maximum and which number is the minimum