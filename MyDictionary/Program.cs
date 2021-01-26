using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string> isimler = new MyDictionary<string>();
            isimler.Add("Yusuf");
            isimler.Add("Erol");
            isimler.Add("Kaan");
            isimler.Add("Emin");
            isimler.Add("Celal");
            isimler.Add("Mert");
            Console.WriteLine(isimler.Count);

        }
    }

    class MyDictionary<T>
    {
        T[] _array;
        T[] _tempArray;
        public MyDictionary()
        {
            _array = new T[0];
        }
        public void Add(T isim)
        {
            _tempArray = _array;
            _array = new T[_array.Length +1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = isim;
        }


        public int Count
        {
            get { return _array.Length; }
        }

    }
}
