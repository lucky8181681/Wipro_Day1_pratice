using System;

namespace Day3
{
    class MethodOverloading
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}