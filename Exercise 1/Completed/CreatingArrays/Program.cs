using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create the array named "intArray"
            int[] intArray = new int[5];

            // TODO: Fill in the array with data
            intArray[0] = 10;
            intArray[1] = 45;
            intArray[2] = 67;
            intArray[3] = 34;
            intArray[4] = 55;

            // TODO: Display the array
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
            //or by using a foreach loop
            //foreach (int i in intArray)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}
