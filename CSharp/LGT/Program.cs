using System;
using System.Runtime.InteropServices;
using Heap;

namespace LGT
{
    class Program
    {
        public class Machine : Heap.IComparable
        {
            public int ID;
            public float Avail = 0;
        }

        public CustomHeap<Machine> Heap = new CustomHeap<Machine>();

        static void Main(string[] args)
        {
            for(var i = 0; i< 3; i++) // 3 is machine count
            {

            }
        }
    }
}
