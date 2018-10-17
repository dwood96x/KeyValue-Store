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
        private KeyValue[] keys = new KeyValue[100];
        private int NumOfKeys = 0;
    }
    class KeySystem
    {
        //IDK if this indexer belongs here
    }
}
