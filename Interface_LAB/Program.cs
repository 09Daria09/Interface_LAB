using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_LAB
{
    class Program
    {
        class Array_ : IOutput, IMath, ISort
        {
            Random random = new Random();
            int[] array = new int[5];

            public float Avg()
            {
                return (float)array.Average();
            }

            public int Max()
            {
                return array.Max();
            }

            public int Min()
            {
                return array.Min();
            }

            public bool Search(int valueToSearch)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == valueToSearch)
                    {
                        return true;
                    }
                }
                return false;
            }

            public void Show()
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(1, 9);
                    Console.Write($"{array[i]}  ");
                }

            }

            public void Show(string info)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"{array[i]  }");
                }
                Console.WriteLine(info);
            }

            public void SortAsc()
            {
                Array.Sort(array);
                foreach (int item in array)
                    Console.Write($" {item} ");
            }

            public void SortByParam(bool isAsc)
            {
                if (isAsc == false)
                    SortDesc();
                else
                    SortAsc();

            }

            public void SortDesc()
            {
                Array.Sort(array);
                Array.Reverse(array);
                foreach (int item in array)
                    Console.Write($" {item} ");
            }
        }
        static void Main(string[] args)
        {
            Array_ array = new Array_();
            array.Show();
            Console.WriteLine();
            Console.WriteLine(array.Min());
            Console.WriteLine();
            Console.WriteLine(array.Max());
            Console.WriteLine();
            Console.WriteLine(array.Search(1));
            Console.WriteLine();
            array.SortAsc();
            Console.WriteLine();
            array.SortDesc();
            Console.WriteLine();
            array.SortByParam(true);

        }
    }
}
