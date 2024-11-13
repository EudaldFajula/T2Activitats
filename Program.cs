using System;

//Pre: The user need to enter a number 
namespace FajulaEudaldEXTnine
{
    public class Exercicinine
    {
        public static int Count(int number)
        {
            int count = 0;
            for (int i = number; i > 0; i /= 10)
            {
                count++;
            }
            return count;
        }
        public static void Power(int number)
        {
            int evenSum = 0;
            int oddSum = 0;
            int residuo = 0;
            for (int i = number; i > 0; i /= 10)
            {
                residuo = (i % 10);
                if (residuo % 2 == 0)
                {
                    evenSum += residuo;
                }
                else
                {
                    oddSum += residuo;
                }
            }
            Console.WriteLine($"La suma de los dígitos pares es: {evenSum}");
            Console.WriteLine($"La suma de los dígitos impares es: {oddSum}");
        }
        public static void Main()
        {
            const string Msg = "Introduce un número:";
            const string MsgCount = "El número tiene {0} dígitos.";
            Console.WriteLine(Msg);
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                int count = Count(number);
                Console.WriteLine(MsgCount, count);
                Power(number);
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}   
//Post: The user will see how long is his number, the odd numbers added up and the even number add up too.