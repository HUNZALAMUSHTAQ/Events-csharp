using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class Pobject : IEnumerable<int>
    {
        private int[] personalKeys = { 32, 23, 51, 15, 91, 19 };

        public IEnumerator<int> GetEnumerator()
        {
            return new MyEnumerator(personalKeys); ;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    internal class MyEnumerator : IEnumerator<int>
    {
        private int[] keys; 
        private int currentIndex = -1 ;
        public MyEnumerator(int[] keys)
        {
            this.keys = keys;
        }
        public int Current => keys[this.currentIndex];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            currentIndex++;
            return currentIndex < keys.Length;
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}
