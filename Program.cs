using System;


//Pre: The user need to enter minutes
namespace FajulaEudaldEXTthirteen
{
    public class Exercicithirteen
    {
        public static int MinToSec(int minutes)
        {
            int seconds = minutes * 60;
            return seconds;
        }
        
        public static void Main()
        {
            const string Msg = "Introdueix cuants minuts vols: ";
            const string FinalMsg = "En segons serien: {0}";
            int minutes;
            Console.WriteLine(Msg);
            try
            {
                minutes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(FinalMsg, MinToSec(minutes));
            }
            catch (Exception)
            {
                
            }
        }
    }
}   
//Post: The user will know how many seconds are in the minutes he entered