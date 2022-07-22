using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LGT
{
    public class Machine
    {
        public int ID;
        public Queue<JOB> Jobs;

        public float Avail
        {
            get
            {
                var avail = .0f;
                foreach(var job in Jobs)
                {
                    avail += job.Avail;
                }

                return avail;
            }
        }

        public Machine(int ID) => this.ID = ID;

        public static bool operator >(Machine a, Machine b) => a.Avail > b.Avail;
        public static bool operator <(Machine a, Machine b) => a.Avail < b.Avail;
    }

    public class JOB
    {
        public float Avail = 0;

        public JOB(float Avail) => this.Avail = Avail;
        
        public void Start()
        {
            /* Work Process */
        }

        static public implicit operator float(JOB job) //엔화를 원화로 변환
        {
            return job.Avail;
        }

        static public implicit operator JOB(float avail) //엔화를 원화로 변환
        {
            return new JOB(avail);
        }
    }

    class Program
    {
        public static CustomHeap<Machine> heap = new CustomHeap<Machine>();
        public JOB[] Jobs = new JOB[] { 8, 7, 6, 5, 3, 2, 1 };

        static void Main(string[] args)
        {


            for(var i = 1; i<= 3; i++) // 3 is machine count
            {
                heap.Add(new Machine(i));
            }

            heap.Remove(2).Jobs
        }
    }
}
