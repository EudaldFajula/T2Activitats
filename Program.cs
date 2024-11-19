using System;

//Pre: The user needs to enter a number 
namespace FajulaEudaldEXTone
{
    public class Exercicione
    {
        public static bool NaturalNumber(int numUser)
        {
            return numUser > 0;
        }
        public static void Main()
        {
            const string Msg = "Introdueix un numero romà: ";
            const string FinalMsg = "El teu número en nombres és: {0}";
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
//Post: The user will know if his number is natural or not