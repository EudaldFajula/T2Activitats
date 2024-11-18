using System;

//Pre: The user need to enter a roman numerals
namespace FajulaEudaldEXTsixteen
{
    public class Exercicisixteen
    {
        public static int RomeNumToNum(string romeNum)
        {
            int normalNum = 0;
            for (int i = romeNum.Length - 1; i >= 0; i--)
            {
                /*Mira quins caracter hi ha en la posicio, depenen del caracter fa una cosa o l'altra.
                IMPORTANT els numero romans que nomes resten son el C = 100, X = 10, I = 1. (Crec que hi han mes)*/
                switch (romeNum[i])
                {
                    case 'M': normalNum += 1000; break;
                    case 'D': normalNum += 500; break;
                    //Cas C = 100. Si hi ha una M = 1000 devant resta o si hi ha una D = 500 tambe resta
                    case 'C': normalNum += (i < romeNum.Length - 1 && (romeNum[i + 1] == 'M' || romeNum[i + 1] == 'D') ? -100 : 100); break;
                    case 'L': normalNum += 50; break;
                    //Cas X = 10. Si hi ha una C= 100 devant resta o si hi ha una L = 50 tambe resta
                    case 'X': normalNum += (i < romeNum.Length - 1 && (romeNum[i + 1] == 'C' || romeNum[i + 1] == 'L') ? -10 : 10); break;
                    case 'V': normalNum += 5; break;
                    //Cas I = 1. Si hi ha una X = 10 devant resta o si hi ha una V = 5 tambe resta
                    case 'I': normalNum += (i < romeNum.Length - 1 && (romeNum[i + 1] == 'X' || romeNum[i + 1] == 'V') ? -1 : 1); break;
                }

            }
            return normalNum;
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
            catch (Exception)
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
//Post: The user will know the roman number in normal numbers
