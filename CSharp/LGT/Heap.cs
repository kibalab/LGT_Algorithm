using System;
using System.Collections.Generic;

namespace LGT
{

    public class CustomHeap<T> where T : Machine
    {
        public CustomHeap()
        { }

        public List<Machine> heap = new List<Machine>(); //Use List<> instead of DynamicArray

        public void Add(Machine data)
        {
            heap.Add(data);

            var lastIndex = heap.Count - 1;
            OrderFromEnd(lastIndex);
        }

        public Machine Remove(int index)
        {
            var removedObject = heap[index];

            var lastIndex = heap.Count - 1;
            heap[index] = heap[lastIndex];
            heap.RemoveAt(index);

            OrderFromFirst(index);

            return removedObject;
        }

        public void OrderFromEnd(int lastIndex)
        {
            var parentIndex = (lastIndex) / 2;
            if (heap[lastIndex] > heap[parentIndex])
            {
                var tmp = heap[parentIndex];
                heap[parentIndex] = heap[lastIndex];
                heap[lastIndex] = tmp;
                OrderFromEnd(parentIndex);
            }
        }

        public void OrderFromFirst(int parentIndex)
        {
            if (heap.Count <= 1 || parentIndex / 2 + 1 >= heap.Count - 1) return;

            var leftChildIndex = (parentIndex) * 2;
            var rightChildIndex = leftChildIndex + 1;


            foreach(var ob in heap)
            {
                Console.WriteLine(ob);
            }

            var largestIndex = -1;
            Console.WriteLine($"[OrderFromFirst] {parentIndex}");
            Console.WriteLine($"[OrderFromFirst] {leftChildIndex}|{rightChildIndex}");

            if (leftChildIndex >= heap.Count || rightChildIndex >= heap.Count) return;
            if (heap[leftChildIndex] > heap[rightChildIndex])
            {
                if (heap[leftChildIndex] < heap[parentIndex]) return;
                largestIndex = leftChildIndex;
            }
            else
            {
                if (heap[rightChildIndex] < heap[parentIndex]) return;
                largestIndex = rightChildIndex;
            }

            if (heap[largestIndex] > heap[parentIndex])
            {
                var tmp = heap[parentIndex];
                heap[parentIndex] = heap[largestIndex];
                heap[largestIndex] = tmp;
                OrderFromFirst(largestIndex);
            }
        }
    }
}
