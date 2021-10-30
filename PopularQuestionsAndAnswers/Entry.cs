using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopularQuestionsAndAnswers
{
    public class HashTable
    {
        private class Entry
        {
            public int Key { get; set; }
            public string Value { get; set; }


            public Entry(int key, string value)
            {
                Key = key;
                Value = value;
            }
        }

        private LinkedList<Entry>[] hashMaps = new LinkedList<Entry>[5];

        public void Put(int key, string value)
        {
            var getEntry = FindAnEntry(key);
            if (getEntry != null)
            {
                getEntry.Value = value;
                return;
            }


            GetOrCreateLinkedList(key).AddFirst(new Entry(key, value));
        }

        public string Get(int key)
        {
            var entry = FindAnEntry(key);
            return entry != null ? entry.Value : null;
        }

        public void Remove(int key)
        {
            var entry = FindAnEntry(key);
            var getList = GetLinkedList(key);
            if (getList != null && entry != null)
            {
                getList.Remove(entry);
            }
        }
        private int Hash( int key)
        {
            return Math.Abs(key % hashMaps.Length);
        }

        private Entry FindAnEntry(int key)
        {
            var getList = GetLinkedList(key);
            return getList != null ? getList.FirstOrDefault(x => x.Key == key) : null;
        }

        private LinkedList<Entry> GetLinkedList(int key)
        {
            var index = Hash(key);
            return index < hashMaps.Length ? hashMaps[index] : null;
        }

        private LinkedList<Entry> GetOrCreateLinkedList(int key)
        {
            var getList = GetLinkedList(key);
            return getList != null ? getList : new LinkedList<Entry>();
        }


    }
}
