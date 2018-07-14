using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        class MyArr
        {
            private int[] Arr;
            public int Length;
            public MyArr(int size)
            {
                Arr = new int[size];
                Length = size;
            }
            public int this[int index]
            {
                get
                {
                    return Arr[index];
                }
                set
                {
                    Arr[index] = value * value;
                }
            }
        }
        static void Main(string[] args)
        {
            MyArr arr = new MyArr(10);

            for (int i = 0; i < 10; i++)
            {
                arr[i] = i;
                Console.Write(arr[i] + " ");
            }
        }
    }
}
