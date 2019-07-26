using System;
using System.Collections;
// ReSharper disable All

namespace GenericsVersusNonGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithArrayList();
        }

        static void SimpleBoxUnboxOperation()
        {
            int myint = 25;
            
            // Boxing
            object boxedInt = myint;

            try
            {
                // Unboxing
                float unboxedInt = (float) boxedInt;
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e);
            }

        }

        static void WorkWithArrayList()
        {
            ArrayList myInts = new ArrayList();
            myInts.Add(10);
            myInts.Add(20);
            myInts.Add(30);

            int myInt = (int) myInts[0];
            
        }
    }
}