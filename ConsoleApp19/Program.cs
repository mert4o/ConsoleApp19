using System;
using System.Collections.Generic;

class Program
{
    static (int count, List<int> positions) LinearSearch(int[] array, int target)
    {
        int count = 0;
        List<int> positions = new List<int>();

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                count++;
                positions.Add(i);
            }
        }

        return (count, positions);
    }

    static void Main()
    {
        Console.Write("Въведете броя на елементите в масива: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        Console.WriteLine("Въведете елементите на масива:");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Въведете търсената стойност: ");
        int target = int.Parse(Console.ReadLine());

        var result = LinearSearch(array, target);

        Console.WriteLine($"Брой намерени елементи: {result.count}");
        Console.WriteLine("Позиции: " + string.Join(", ", result.positions));
    }
}   

