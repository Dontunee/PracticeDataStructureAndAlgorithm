using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers.Fundamentals
{
    public class PriorityQueue<T> where T : IComparable
    {
        private int heapSize;
        private int heapCapacity;
        private List<T> heap;
        
        private Dictionary<T, HashSet<int>> map = new Dictionary<T, HashSet<int>>();

        public PriorityQueue(int capacity)
        {
            heap = new List<T>(capacity);
        }

        public PriorityQueue(T[] items)
        {
            heapCapacity = items.Length;
            heap = new List<T>(items.Length);
            int[] mapAdd = new int[items.Length];

            for(int i = 0; i < heap.Count; i++)
            {
                if (map.ContainsKey(items[i]))
                {
                    var mapHash = map.GetValueOrDefault(items[i]);
                    mapHash.Add(i);
                }
                else
                {
                    heap.Add(items[i]);
                    var mapHash = new HashSet<int>();
                    mapHash.Add(i);
                    map.Add(items[i], mapHash);
                }
            }


            //Heapify process
        }

        //public T Poll()
        //{
        //    return object;
        //    // remove at index 0
        //}

        public void Add(T element)
        {
            if (element is null) return;

            heap.Add(element);
            heapCapacity++;

            if (map.ContainsKey(element))
            {
                var mapHash = map.GetValueOrDefault(element);
                mapHash.Add(heapSize);
            }
            else
            {
                var mapHash = new HashSet<int>();
                mapHash.Add(heapSize);
                map.Add(element, mapHash);
            }
            swim(heapSize);
            heapSize++;
        }

        public bool lessThan(int i, int j)
        {
            var node1 = heap[i];
            var node2 = heap[j];

            return node1.CompareTo(node2) <= 0;
        }

        private void swim (int k)
        {
            var parent = (k - 1) / 2;
            
            while(k > 0 && lessThan(k,parent))
            {
                swap(parent, k);
                k = parent;
                parent = (k - 1) / 2;
            }
        }

        private void sink(int k)
        {
            while (true)
            {
                int left = 2 * k * +1;
                int right = 2 * k + 2;

                int smallest = left;

                if (right < heapSize && lessThan(right, left))
                    smallest = right;

                if (left >= heapSize && lessThan(k, smallest))
                    break;

                swap(smallest, k);
                k = smallest;

            }
        }

        private void swap (int i , int j)
        {
            var i_Element = heap[i];
            var j_Element = heap[j];
            heap[j] = i_Element;
            heap[i] = j_Element;

            mapSwap(i_Element, j_Element, i, j);
        }

        private void mapSwap(T i_Element, T j_Element, int i, int j)
        {
            throw new NotImplementedException();
        }

        private T RemoveAt(int i)
        {
            heapSize--;
            var dataToRemove = heap[i];
            swap(i, heapSize);

            heap[heapSize] = default(T);
            //remove from map
            mapRemove(dataToRemove, heapSize);

            if (i == heapSize) return dataToRemove;

            var elementToSinkOrSwap = heap[i];

            sink(i);

            if (heap[i].Equals(elementToSinkOrSwap));
                swim(i);

            return dataToRemove;
        }

        private void mapRemove(T dataToRemove, int heapSize)
        {
            throw new NotImplementedException();
        }

        public bool IsMinimumHeap(int k)
        {
            if (k > heapSize) return true;
            var rootValue = heap[k];

            var leftPosition = 2 * k +1 ;
            var rightPosition = 2 * k + 2;

            if (leftPosition < heapSize && !lessThan(k, leftPosition)) return false;
            if (rightPosition < heapSize && !lessThan(k, rightPosition)) return false;

            return IsMinimumHeap(leftPosition) && IsMinimumHeap(rightPosition);
        }
    }
}
