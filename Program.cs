using System;

//Pre: The user needs to enter a text
namespace FajulaEudaldEXTseven
{
    public class Exerciciseven
    {
        public static string Change(string text)
        {
            int CheckLower = 0;
            int CheckUpper = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text, i))
                {
                    CheckUpper++;
                }
                else
                    CheckLower++;
            }
            if (CheckUpper > CheckLower)
            {
                return text.ToLower();
            }
            else
            {
                return text.ToUpper();
            }
        }
        public static void Main()
        {
            const string Msg = "Please write a text: ";
            string text = "";

            Console.WriteLine(Msg);
            try
            {
                text = Console.ReadLine();
                Console.WriteLine($"Your text: {Change(text)}");
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
//Post: The user will see his text transformed to upper or lower