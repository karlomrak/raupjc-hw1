using System;
using System.Linq;
using Assignment1;

namespace Assignment1
{
    public class IntegerList : IIntegerList

    {
        private int[] _internalStorage;
        private int last;


        public IntegerList()
        {
            _internalStorage = new int[4];
            last = -1;
        }

        public IntegerList(int initialSize)
        {
            if (initialSize < 1)
            {
                throw new ArgumentException("Argument mora biti veći od 0!");
            }
            else
            {
                _internalStorage = new int[initialSize];
                last = -1;
            }

        }

        public void Add(int item)
        {
            int length = _internalStorage.Length;
            if (length == Count)
            {
                int[] pom = new int[length * 2];
                Array.Copy(_internalStorage, pom, length);
                _internalStorage = pom;

            }
            last++;
            _internalStorage[last] = item;
        }

        public bool RemoveAt(int index)
        {
            int lastIndex = _internalStorage.Length - 1;
            if (index > Count)
            {
                //throw new IndexOutOfRangeException();
                return false;
            }
            else
            {
                for (int i = index; i < Count; i++)
                {
                    _internalStorage[i] = _internalStorage[i + 1];
                }
                last--;
                return true;

            }
        }

        public bool Remove(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return RemoveAt(i);
                }
            }
            return false;
        }

        public int GetElement(int index)
        {
            if (index < Count)
            {
                return _internalStorage[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

        }

        public int Count => last + 1;


        public void Clear()
        {
            int length = _internalStorage.Length;
            _internalStorage = new int[length];
            last = -1;
        }

        public bool Contains(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return true;
                }

            }
            return false;
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}