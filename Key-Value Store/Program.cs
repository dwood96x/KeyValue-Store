using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_Value_Store
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    struct KeyValue
    {
        public string key { get; }
        public object value { get; }
        public KeyValue(string _key,object _value)
        {
            key = _key;
            value = _value;
        }
    }
    class MyDictionary
    {
        private KeyValue[] keys = new KeyValue[50];
        private int NumOfKeys = 0;

        public object this[string key]
        {
            set
            {
                for (int i = 0; i < keys.Length; i++)
                {
                    if (keys[i].key == key)
                    {
                        keys[i].key = Console.ReadLine();
                    }
                }
            }
            get
            {
                for (int i = 0; i < keys.Length; i++)
                {
                    if (keys[i].key == key)
                    {
                        return keys[i].value;
                    }
                }
                throw new KeyNotFoundException();
            }
        }
    }
}
