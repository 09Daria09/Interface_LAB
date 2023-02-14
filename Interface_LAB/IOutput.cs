using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_LAB
{
    interface IOutput
    {
        void Show();
        void Show(string info);
    }
    class Array : IOutput
    {
        Random random = new Random();
        int[] array = new int[5];
        public void Show()
        {
            for(int i = 0; i< array.Length; i ++)
            {
                array[i] = random.Next(1, 9);
                Console.WriteLine($"{array[i]  }");
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
    }
}
