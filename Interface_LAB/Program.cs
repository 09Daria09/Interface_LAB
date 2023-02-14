using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_LAB
{
    class Program
    {
        class Array_ : IOutput, IMath, ISort, ICalc, IOutput2, ICalc2
        {
            Random random = new Random();
            int[] array = new int[10];

            public float Avg()
            {
                return (float)array.Average();
            }

            public int CountDistinct()
            {
                int count = 0;
                int count1 = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    for(int j = 0; j < array.Length; j++)
                    {
                        if(array[i] != array[j])
                            count++;
                    }
                    if(count == array.Length - 1)
                        count1++;
                    count = 0;
                }

                return count1;
            }

            public int EqualToValue(int valueToCompare)
            {
                int count = 0;
                for(int i = 0;i < array.Length; i++)
                {
                    if(array[i] == valueToCompare)
                    {
                        count++;
                    }
                }
                return count;
            }

            public int Greater(int valueToCompare)
            {
                int count = 0;
                for(int i =0; i < array.Length; i++)
                {
                    if(array[i] > valueToCompare)
                    {
                        count++;
                    }
                }
                return count;
            }

            public int Less(int valueToCompare)
            {
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < valueToCompare)
                    {
                        count++;
                    }
                }
                return count;
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
                    array[i] = random.Next(1, 20);
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

            public void ShowEven()
            {
                for(int i = 0; i < array.Length; i++)
                {
                    if(array[i]% 2 == 0)
                    {
                        Console.Write($"{array[i]}  ");
                    }
                }
            }

            public void ShowOdd()
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        Console.Write($"{array[i]}  ");
                    }
                }
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

            Console.WriteLine(array.CountDistinct());

            Console.WriteLine(array.EqualToValue(3));

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
            Console.WriteLine();

            Console.WriteLine(array.Greater(3));
            Console.WriteLine(array.Less(2));
            Console.WriteLine();

            array.ShowEven();
            Console.WriteLine();

            array.ShowOdd();
            Console.WriteLine();

        }
    }
}
