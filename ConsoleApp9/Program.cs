using System.Runtime.InteropServices;

namespace ConsoleApp9
{
    internal class Program
    {
        class GenericPractic<T>
        {
            dynamic[] arr = { 2, 3, 4 };
            dynamic gen_Max_Value(int[] arr)
            {
                int max = 0;
                for (int i = 0; i < arr.Length; i++) 
                {
                    if (arr[i] > arr[i + 1])
                    {
                        max = arr[i];
                    }
                }
                return max;
            }
            dynamic gen_Min_Value(int[] arr)
            {
                int min = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        min = arr[i];
                    }
                }
                return min;
            }

            dynamic gen_Sum_arr(int[] arr)
            {
                dynamic sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                return sum;
            }
        }
        class GenStek
        {
            dynamic[] a;
            void pop() 
            {
                dynamic[] buff_arr = null;
                if (a == null)
                {
                    Console.WriteLine("Error");
                    return;
                }
                else 
                { 
                    for (int i = 0; i > a.Length; i++) 
                    {
                        buff_arr[i] = a[i+1];
                    }
                }
                Console.WriteLine(a[0]);
                a = buff_arr;
            }
            void push(int num, dynamic data) 
            {
                dynamic[] buff_arr = null;
                if (a.Length < num)
                {
                    Console.WriteLine("Error");
                    return;
                }
                else
                {
                    for (int i = 0; a.Length > num; i++)
                    {
                        buff_arr[i] = a[i];
                    }
                    buff_arr[num] = data;
                    for (int i = num + 1; i > a.Length; i++)
                    {
                        buff_arr[i] = a[i + 1];
                    }
                }
            }
            dynamic peek() { return a[1]; }
            int count() { return a.Length; }
        }
        class GenQueue
        {
            dynamic[] a;
            void enqueue(dynamic data)
            {
                a[a.Length] = data;
            }
            void dequeue() 
            {
                dynamic[] buff_arr = null;
                if (a == null)
                {
                    Console.WriteLine("Error");
                    return;
                }
                else
                {
                    for (int i = 0; i > a.Length; i++)
                    {
                        buff_arr[i] = a[i + 1];
                    }
                }
                Console.WriteLine(a[0]);
                a = buff_arr;
            }
            dynamic peek() { return a[1]; }
            int count() { return a.Length; }

        }
        static void Main(string[] args)
        {
            
        }
    }
}