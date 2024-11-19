using System;

//Pre: The user needs to enter how many numbers want to enter
namespace FajulaEudaldEXTseventeen
{
    public class Exerciciseventeen
    {
        public static int[] PrintArray(int number, string MsgNum)
        {
            int[] arrayNums = new int[number];
            for(int i = 0; i < arrayNums.Length; i++)
            {
                Console.WriteLine(MsgNum);
                arrayNums[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arrayNums;
        }
        public static void Main()
        {
            const string Msg = "Introdueix cuants valors vols: ";
            const string MsgNum = "Introdueix valor: ";
            int[] arrayNums;
            Console.WriteLine(Msg);
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                arrayNums = PrintArray(number, MsgNum);
                for (int i = 0; i < arrayNums.Length; i++)
                {
                    Console.Write($"{arrayNums[i]}, ");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
//Post: The user will have his numbers in order
