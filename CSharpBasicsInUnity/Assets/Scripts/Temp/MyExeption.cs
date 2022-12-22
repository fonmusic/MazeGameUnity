using System;

namespace GB
{

    public class MyExeption : Exception
    {
        public int Value { get; }

        public MyExeption(string message, int val) : base(message)
        {
            Value = val;
        }


    }
}