using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_4
{
    class Sort<T>
    {
        string result;
        public Sort(T[] my_array)
        {
            result = string.Join(";", Buble(my_array));
        }
        public Sort(T[] my_array, int a)
        {
            result = string.Join(";", Select(my_array));
        }
        public Sort(T[] my_array, int l,int r)
        {
            result = string.Join(";", MergeSort(my_array,l,r));
        }
        /// <summary>
        /// Метод сортировки пузырьком
        /// </summary>
        T[] Buble(T[] my_array)
        {
            for (int i = 0; i < my_array.Length; i++)
            {
                for (int j = 0; j < my_array.Length - 1; j++)
                {
                    dynamic d_my_arraySort = my_array[j], d_my_arraySort1 = my_array[j + 1];
                    if (d_my_arraySort > d_my_arraySort1)
                    {
                        T temp = my_array[j + 1];
                        my_array[j + 1] = my_array[j];
                        my_array[j] = temp;
                    }
                }
            }
            return my_array;
        }
        /// <summary>
        /// Метод получения значений
        /// </summary>
        public string Get()
        {
            return result;
        }
        /// <summary>
        /// Метод сортировки выбором
        /// </summary>
        T[] Select(T[] my_array)
        {
            for (int i = 0; i < my_array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < my_array.Length; j++)
                {
                    dynamic d_my_arraySortMin = my_array[min], d_my_arraySortJ = my_array[j];
                    if (d_my_arraySortJ < d_my_arraySortMin)
                    {
                        min = j;
                    }
                }
                T temp = my_array[min];
                my_array[min] = my_array[i];
                my_array[i] = temp;
            }
            return my_array;
        }
        /// <summary>
        /// Метод сортировки слиянием
        /// </summary>
        static void Merge(T[] my_array, int l, int m, int r)
        {
            int i, j, k;

            int n1 = m - l + 1;
            int n2 = r - m;

            T[] left1 = new T[n1 + 1];
            T[] right1 = new T[n2 + 1];
            dynamic a = my_array, MaxValue = Double.MaxValue, left = left1, right = right1;
            for (i = 0; i < n1; i++)
            {
                left[i] = a[l + i];
            }

            for (j = 1; j <= n2; j++)
            {
                right[j - 1] = a[m + j];
            }
            left[n1] = MaxValue;
            right[n2] = MaxValue;

            i = 0;
            j = 0;

            for (k = l; k <= r; k++)
            {
                if (left[i] < right[j])
                {
                    a[k] = left[i];
                    i +=  1;
                }
                else
                {
                    a[k] = right[j];
                    j = j + 1;
                }
            }
        }
        /// <summary>
        /// Рекурсивный вызов метода слияния
        /// </summary>
        static T[] MergeSort(T[] a, int l, int r)
        {
            int q;
            if (l < r)
            {
                q = (l + r) / 2;
                MergeSort(a, l, q);
                MergeSort(a, q + 1, r);
                Merge(a, l, q, r);
            }
            return a;
        }
    }
}
