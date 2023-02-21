using System;

namespace quick_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Быстрая сортировка
            int[] array = new int[] { 73, 57, 49, 99, 133, 20, 1 };
            int[] quickSortedArray = QuickSortArray(array, 0, array.Length - 1);
            foreach (int elem in quickSortedArray)
                Console.WriteLine(elem);
            Console.WriteLine("////");


            // пузырьком сортировка
            int[] bubbleSortedArray = BubbleSortArray(array);
            foreach (int elem in bubbleSortedArray)
                Console.WriteLine(elem);
            Console.WriteLine("////");


            // сортировка вставками
            int[] pasteSortArray = PasteSortArray(array);
            foreach (int elem in pasteSortArray)
                Console.WriteLine(elem);
            Console.WriteLine("////");

            // сортировка выбором
            int[] choiseSortArray = ChoiseSortArray(array);
            foreach (int elem in choiseSortArray)
                Console.WriteLine(elem);
        }

        public static int[] QuickSortArray(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                QuickSortArray(array, leftIndex, j);
            if (i < rightIndex)
                QuickSortArray(array, i, rightIndex);
            return array;
        }

        public static int[] BubbleSortArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int k = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = k;
                    }
                }
            return array;
        }

        public static int[] PasteSortArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int k = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > k)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = k;
            }
            return array;
        }

        public static int[] ChoiseSortArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++) // цикл фор пробигается от первого элемента массива до последнего
            {
                int minIndex = i;
                for (int j = i; j < array.Length; j++)// ищем элемент с наименьшим значением
                {
                    if (array[minIndex] > array[j])
                    {
                        minIndex = j;
                    }
                }
                int k = array[i];//приравниваем найденный минимальный индекс к перовлму i 
                array[i] = array[minIndex];
                array[minIndex] = k;
            }
            return array;
        }
    }
}