using System;

namespace EudaldAct
{
    public class Act23
    {
        public static bool ValidateNum(decimal num)
        {
            return num > 0;
        }
        public static bool ValidateNum(int num)
        {
            return num > 0;
        }
        public static decimal[] BubbleSort(decimal[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j< array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        decimal aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                }
            }
            return array;
        }
        public static bool SearchNumArray(decimal num, decimal[] array)
        {
            return array.Contains(num);
        }
        //HOli
        public static char[] Histogram(decimal[] array)
        {
            char[] arrayHistogram;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j< array.Length; j++)
                {
                    if (array[j].Equals(array[i]))
                    {
                        arrayHistogram[i] = '*';
                    }
                }
            }
        }
        public static void Main()
        {
            const string Msg = "Quants valors vols emmagatzemar?";
            const string ValueMsg = "Introdueix el valor {0}: ";
            const string QuestionMsg = "\nQuin valor vols trobar?";
            const string NumInArrayMsg = "El teu valor esta en el array";
            const string NumNoInArrayMsg = "El teu valor no esta en el array";
            int quantity = 0;
            decimal numSearch;
            Console.WriteLine(Msg);
            // Pregunta cuantos numeros quieres poner en el array
            do
            {
                quantity = Convert.ToInt32(Console.ReadLine());
            } while (!ValidateNum(quantity));
            decimal[] arrayTemp = new decimal[quantity];
            //Poner numeros en el array
            for (int i = 0; i < arrayTemp.Length; i++)
            {
                do
                {
                    Console.WriteLine(ValueMsg, i + 1);
                    arrayTemp[i] = Convert.ToDecimal(Console.ReadLine());
                } while (!ValidateNum(arrayTemp[i]));
            }
            //Poner los numeros del array de manera ascendent
            arrayTemp = BubbleSort(arrayTemp);
            //Printa el array
            for (int i = 0;i < arrayTemp.Length; i++)
            {
                Console.Write($"{arrayTemp[i]}, ");
            }
            //Pregunta al usuari quin numero vol buscar
            Console.WriteLine(QuestionMsg);
            numSearch = Convert.ToInt32(Console.ReadLine());
            //Diu al usuari si el seu numero existeix en el array
            Console.WriteLine(SearchNumArray(numSearch, arrayTemp) ? NumInArrayMsg:NumNoInArrayMsg);
            char[] arrayHistogram = Histogram(arrayTemp);
        }
    }
}