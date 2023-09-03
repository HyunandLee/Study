using System;

namespace CSharpDataStructuresAlogrithms
{
    class TestOneArrayAppend
    {
        public static int[] Add(int[] array, int value)
        {
            int[] tempArray = new int[array.Length + 1];

            for(int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }

            tempArray[array.Length] = value;

            return tempArray;
        }

        static void Main(string[] args)
        {
            int[] array = { 90, 70, 50, 80, 60, 85 };

            array = Add(array, 75);//配列の後尾に75を追加

            for(int i = 0; i<array.Length; i++)
            {
                Console.Write(array[i] + ",");
            }
        }
    }
}