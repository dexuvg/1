/* пользователь вводит реакгенты, программа делит их на атомы, молярную массу, давление температуру. 
на выходе получает жидкость и может получить газ/осадок*/

using System;
using System.Globalization;
using System.Runtime.ExceptionServices;

namespace ConsoleApp1
{
    internal class Program
    {

        public struct Reagent
        {
            public string name;
            public double mass;
            public float pressure;
            public float temperature;
            public string simpleOrNot;
        }

        static void Main(string[] args)
        {
            Console.Clear();

            Reagent firstReagent = new Reagent();
            Console.Write("Название: ");
            firstReagent.name = Console.ReadLine();
            char[] firstReagentNameArray = firstReagent.name.ToCharArray();
            string firstSubstanceInFirst = "";
            int startIndex = -1;
            if (!string.IsNullOrEmpty(firstReagent.name))
            {
                for (int i = 0; i < firstReagentNameArray.Length; i++)
                {
                    if (char.IsUpper(firstReagentNameArray[i]))
                    {
                        startIndex = i;
                        break;
                    }
                }
                if (startIndex != -1)
                {
                    firstSubstanceInFirst += firstReagent.name[startIndex];

                    for (int i = startIndex + 1; i < firstReagent.name.Length; i++)
                    {
                        if (!char.IsUpper(firstReagent.name[i]))
                        {
                            firstSubstanceInFirst += firstReagent.name[i];
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine($"{firstSubstanceInFirst}");
            //Console.Write("Молярная масса: ");
            //firstReagent.mass = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Давление: ");
            //firstReagent.pressure = float.Parse(Console.ReadLine());
            //Console.Write("Температура: ");
            //firstReagent.temperature = float.Parse(Console.ReadLine());

            //Reagent secondReagent = new Reagent();
            //Console.Write("Название: ");
            //secondReagent.name = Console.ReadLine();

            //Console.Write("Молярная масса: ");
            //secondReagent.mass = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Давление: ");
            //secondReagent.pressure = float.Parse(Console.ReadLine());
            //Console.Write("Температура: ");
            //secondReagent.temperature = float.Parse(Console.ReadLine());

            //расчет уравнения
            Console.ReadKey();
        }
    }
}
