using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using Microsoft.VisualBasic;

//Pre: The user need to enter how many values want to enter
namespace FajulaEudaldEXTeleven
{
    public class Exercicieleven
    {
        public static int AskHowManyNum()
        {
            const string Msg = "Introdueix quants valors vols introduir:";
            int number;
            Console.WriteLine(Msg);
            number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public static int[] EnterNumArray(int HowManyNum)
        {
            const string Msg = "Introdueix numero: ";
            int number;
            int[] ListValues = new int[HowManyNum];
            for (int i = 0; i < ListValues.Length; i++)
            {
                do
                {
                    Console.WriteLine(Msg);
                    number = Convert.ToInt32(Console.ReadLine());
                    ListValues[i] = number;
                } while (number < 15 || number > 100);
            }
            return ListValues;
        }
        public static void Main()
        {
            int[] ListValuesTotal;
            try
            {
                int HowManyNum = AskHowManyNum();
                ListValuesTotal = EnterNumArray(HowManyNum);
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}   
//Post: The user will have a list of the values he entered