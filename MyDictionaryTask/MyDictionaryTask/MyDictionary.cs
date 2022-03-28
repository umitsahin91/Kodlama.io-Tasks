using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionaryTask
{
    class MyDictionary<TKey, TValue> : Exception
    {
        TKey[] keysArr;
        TValue[] valuesArr;
        private int lenght = 0;
        public MyDictionary()
        {
            keysArr = new TKey[lenght];
            valuesArr = new TValue[lenght];
        }
        public MyDictionary(TKey key, TValue value)
        {
            keysArr = new TKey[lenght];
            valuesArr = new TValue[lenght];
            Add(key, value);
        }
        public int Lenght
        {
            get { return lenght; }

        }
        public void Add(TKey key, TValue value)
        {
            if (keysArr.Contains(key))
            {
                throw new ArgumentException($"An item with the same key has already been added. Key: {key}'");
            }
            TKey[] tempKeysArr = keysArr;
            TValue[] tempValueArr = valuesArr;
            keysArr = new TKey[lenght + 1];
            valuesArr = new TValue[lenght + 1];
            for (int i = 0; i < lenght; i++)
            {
                keysArr[i] = tempKeysArr[i];
                valuesArr[i] = tempValueArr[i];
            }

            keysArr[lenght] = key;
            valuesArr[lenght] = value;
            lenght++;
        }

    }
}
