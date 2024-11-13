using System;

//Pre: The user need to enter a year 
namespace FajulaEudaldEXTten
{
    public class Exerciciten
    {
        public static bool LeapYear(int year)
        {
            if (year % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public static void Main()
        {
            const string Msg = "Introduce un número:";
            const string MsgYearTrue = "El teu any es de traspas";
            const string MsgYearFlase = "El teu any no es de traspas";
            Console.WriteLine(Msg);
            try
            {
                int LeapYearValidate = Convert.ToInt32(Console.ReadLine());
                if (LeapYear(LeapYearValidate))
                {
                    Console.WriteLine(MsgYearTrue);
                }
                else
                {
                    Console.WriteLine(MsgYearFlase);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}   
//Post: The user will know if the year is leap or not.