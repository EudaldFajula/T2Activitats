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
            // Inici Exercici 1
            const string Msg = "Please write a number: ";
            const string NaturalNum = "És natural";
            const string NoNaturalNum = "No és natural";
            const string ErrorNoNum = "ERROR no es un numero";

            int numUser;
            Console.WriteLine(Msg);
            try
            {
                numUser = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(NaturalNumber(numUser) ? NaturalNum : NoNaturalNum);
       
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