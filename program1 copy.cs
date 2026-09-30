using System;
using System.Runtime.CompilerServices;

class Program
{

    
    static void Main(string[] args)
    {
        string numStr = "";
        int number = -1;
        var list = new List<int>();
        int smallestNum = 1000000;
        int largestNum = -1000000;
        int sum = 0;
        bool added = false;

        while(true)
        {
            Console.WriteLine("Number");
            numStr = Console.ReadLine();
            number = Int32.Parse(numStr);

            if (number == 0)
            {
                break;
            }

            if (number > largestNum)
            {
                largestNum = number;
            }
            if (number < smallestNum && number > 0)
            {
                smallestNum = number;
            }

            for (int index = 0; index != list.Count; index++)
            {
                if (number < list[index])
                {
                    list.Insert(index, number);
                    added = true;
                    break;
                }
            }
            if (!added)
            {
                list.Add(number);
            }
            added = false;
            sum+=number;
        }
        Console.WriteLine("smallest " + smallestNum);
        Console.WriteLine("biggest " + largestNum);
        Console.WriteLine("Sum "+sum);
        Console.WriteLine("Average "+sum/list.Count);
        Console.WriteLine("All nums");
        for (int index = 0; index != list.Count; index++)
        {
            Console.WriteLine(list[index]);
        }





    }
}