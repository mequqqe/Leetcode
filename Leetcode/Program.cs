using System;namespace InsertionSortTemplate{    class Program    {        static void Main(string[] args)        {                        int[] arrayToSort = { 5, 2, 9, 1, 5, 6 };                        Console.WriteLine("Initial array: " + string.Join(", ", arrayToSort));                        InsertionSort(arrayToSort);                        Console.WriteLine("Sorted array: " + string.Join(", ", arrayToSort));        }        static void InsertionSort(int[] array)        {
            for (int i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }        }    }}