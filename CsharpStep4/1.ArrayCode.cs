using System;

namespace ArrayCode
{
    class Arrays
    {
        static void Main()
        {
            //1.Typesafety: we can create array with same datatype

            int[] arr = new int[2];
            arr[0] = 1;
            arr[1] = 2;

            //2.array with fixed size

            int[] arr2 = new int[2];
            arr2[0] = 3;
            arr2[1] = 4;
            //arr2[2] = 5; exception
            //arr2[3] = 9;

            //3.boxing and unboxing
            //or no boxing

            //int third = arr2[0];

            //4.Multidata types: can't create multiple data types
            int[] arr3 = new int[2];
            //arr2[0] = false
            //arr2[1] = "Hello";

            //5. looping
            int[] arr4 = new int[4];
            arr4[0] = 5;
            arr4[1] = 6;
            arr4[2] = 7;
            arr4[3] = 8;

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

        }

    }
}
