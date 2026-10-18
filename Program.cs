using System;
using System.Globalization;
using System.Linq;

namespace _2
{
    internal class Program
    {
        public class Reagent
        {
            public string name;
        }
        static void Main(string[] args)
        {
            Console.Clear();
            Reagent firstReagent = new Reagent();
            Console.Write("Название: ");
            firstReagent.name = Console.ReadLine();
            char[] firstNameArray = firstReagent.name.ToCharArray();
            string firstInFirst = "";
            string secondInFirst = "";
            string nameTemp = "";
            string firstInFirstCount = "1";
            string secondInFirstCount = "1";
            string countTemp = "1";
            if (!string.IsNullOrEmpty(firstReagent.name))
            {
                for (int i = 0; i < firstNameArray.Length; i++)
                {
                    if (char.IsUpper(firstNameArray[i]) && nameTemp != "")
                    {
                        if (firstInFirst == "") firstInFirst = nameTemp;
                        else secondInFirst = nameTemp;
                        nameTemp = "";
                    }
                    if (char.IsDigit(firstNameArray[i]))
                    {
                        countTemp = char.ToString(firstNameArray[i]);
                        if (firstInFirst == "") firstInFirstCount = countTemp;
                        else secondInFirstCount = countTemp;
                        continue;
                    }
                    else
                    {
                        nameTemp += firstNameArray[i];
                    }
                }
                if (nameTemp != "")
                {
                    if (firstInFirst == "") firstInFirst = nameTemp;
                    else secondInFirst = nameTemp;
                }
            }
            string[] groups = { "OH", "SO4", "NO3", "CO3", "PO4", "NH4" };
            foreach (string group in groups)
            {
                if (firstReagent.name.Contains(group))
                {
                    secondInFirst = group;
                    secondInFirstCount = "1";
                }
            }
            Console.WriteLine($"Первое вещество: {firstInFirst}");
            Console.WriteLine($"Количество атомов в первом веществе: {firstInFirstCount}");
            if (!string.IsNullOrEmpty(secondInFirst))
            {
                Console.WriteLine($"Второе вещество: {secondInFirst}");
                Console.WriteLine($"Количество атомов во втором веществе: {secondInFirstCount}");
            }
            Console.ReadKey();
        }
    }
}
