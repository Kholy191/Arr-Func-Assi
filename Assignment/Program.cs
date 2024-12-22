using System.Numerics;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q19 Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.   
            //for (; ; )
            //{
            //    Boolean Flag = int.TryParse(Console.ReadLine(), out int N);
            //    if (Flag & N != 0)
            //    {
            //        int[,] IdentityMat = new int[N, N];
            //        for (int i = 0; i < IdentityMat.GetLength(0); i++)
            //        {
            //            for (int j = 0; j < IdentityMat.GetLength(1); j++)
            //            {
            //                if (i == j)
            //                {
            //                    IdentityMat[i, j] = 1;
            //                }
            //                Console.Write($"{IdentityMat[i, j]} ");
            //            }
            //            Console.WriteLine();
            //        }
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Enter Number Greater than Zero");
            //    }
            //}
            #endregion

            #region Q20 Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] Nums = new int[] { 1, 6, 7, 1, 4, 7 };
            //int sum = 0; 
            //for (int i = 0; i < Nums.Length; i++)
            //{
            //    sum += Nums[i];
            //}
            //Console.WriteLine($"Sum = {sum}");
            #endregion

            #region Q21 Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int[] Nums1 = new int[] { 1, 6, 7, 10, 4 };
            //int[] Nums2 = new int[] { 3, 2, 5, 8, 9 };
            //int[] Result = new int[(Nums1.Length * 2)];

            //for (int i = 0; i < Result.Length; i++)
            //{
            //    if (i >= (Result.Length / 2))
            //        Result[i] = Nums2[i - (Result.Length / 2)];
            //    else
            //        Result[i] = Nums1[i];
            //}
            //Array.Sort(Result);

            //for (int i = 0; i < Result.Length; i++)
            //{
            //    Console.WriteLine(Result[i]);
            //}
            #endregion

            #region Q22 Write a program in C# Sharp to count the frequency of each element of an array
            //int[] Nums1 = new int[] { 1, 1, 7, 10, 1, 4, 5, 7 , 10};
            //int[] NumscheckArr = new int[Nums1.Length];
            //for (int i = 0; i < Nums1.Length; i++)
            //{
            //    Boolean Checker = false;
            //    for (int j = 0; j < Nums1.Length; j++)
            //    {
            //        if (Nums1[i] == NumscheckArr[j])
            //        {
            //            Checker = true;
            //            break;
            //        }
            //    }
            //    if (Checker)
            //    {
            //        continue;
            //    }
            //    NumscheckArr[i] = Nums1[i];
            //    int count = 0;
            //    for (int j = 0; j < Nums1.Length; j++)
            //    {
            //        if (Nums1[i] == Nums1[j])
            //        {
            //            count++;
            //        }
            //    }
            //    Console.WriteLine($"{Nums1[i]} Freq is {count}");
            //}

            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine("Another Solution with enhanced time complexty");

            ///*Another Solution with enhanced time complexty*/ /*------------------*/

            //Array.Sort(Nums1);
            //int CurrentNum = Nums1[0];
            //int count2 = 0;

            //for (int i = 0; i < Nums1.Length; i++)
            //{
            //    if (Nums1[i] == CurrentNum)
            //    {
            //        count2++;
            //        if (i == Nums1.Length - 1)
            //            Console.WriteLine($"Num1 = {CurrentNum} is {count2}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Num1 = {CurrentNum} is {count2}");
            //        CurrentNum = Nums1[i];
            //        count2 = 1;
            //        if (i == Nums1.Length - 1)
            //            Console.WriteLine($"Num1 = {CurrentNum} is {count2}");
            //    }
            //}
            #endregion

            #region Q23 Write a program in C# Sharp to find maximum and minimum element in an array
            //int[] Nums1 = new int[] { 1, 1, 7, 10, 1, 4, 5, 7, 10 };
            //int Max = Nums1[0], Min = Nums1[0];

            //for (int i = 0; i < Nums1.Length; i++)
            //{
            //    if (Nums1[i] > Max)
            //        Max = Nums1[i];
            //    if (Nums1[i] < Min)
            //        Min = Nums1[i];
            //}
            //Console.WriteLine($"Max Number is {Max} and Min is {Min}");
            #endregion

            #region Q24 Write a program in C# Sharp to find the second largest element in an array.
            //int[] Nums1 = new int[] { 1, 1, 7, 10, 1, 4, 5, 7, 10 };
            //int Max = Nums1[0], Previos = Nums1[0];

            //for (int i = 0; i < Nums1.Length; i++)
            //{
            //    if (Nums1[i] > Max)
            //    {
            //        Previos = Max;
            //        Max = Nums1[i];
            //    }
            //}
            //Console.WriteLine($"sec Max Number is {Previos}");
            #endregion

            #region Q25 Consider an Array of Integer values with size N, having values as in this Example
            //int[] Nums = new int[8];
            //int LongestDis = 0;
            //for (int i = 0; i < Nums.Length; i++)
            //{
            //    Console.WriteLine($"enter value of index{i}");
            //    int.TryParse(Console.ReadLine(), out Nums[i]);
            //}
            //if (Nums[0] == Nums[Nums.Length - 1])
            //    Console.WriteLine(Nums.Length);
            //else
            //{
            //    for (int i = 0; i < Nums.Length; i++)
            //    {
            //        for (int j = 0; j < Nums.Length; j++)
            //        {
            //            if (Nums[i] == Nums[j])
            //            {
            //                if ((j - i - 1) > LongestDis)
            //                {
            //                    LongestDis = j - i - 1;
            //                }
            //            }
            //        }
            //    }
            //    Console.WriteLine($"Longest Distance is {LongestDis}");
            //}
            #endregion

            #region Q26 Given a list of space separated words, reverse the order of the words.
            //string input;
            //for (; ; )
            //{
            //    input = Console.ReadLine();
            //    if (input == null)
            //    {
            //        Console.WriteLine("You Entered Wrong Nums");
            //    }
            //    else
            //        break;
            //}

            //string[] strings = input.Split(" ");

            //for (int i = strings.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($"{strings[i]} ");
            //}
            #endregion

            #region Q27 Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            //Console.Write("Enter the number of rows: ");
            //int.TryParse(Console.ReadLine(), out int rows);
            //Console.Write("Enter the number of columns: ");
            //int.TryParse(Console.ReadLine(), out int Cols);

            //int[,] firstArray = new int[rows, Cols];
            //int[,] secondArray = new int[rows, Cols];

            //Console.WriteLine("Enter values for the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < Cols; j++)
            //    {
            //        Console.Write($"Element [{i}, {j}]: ");
            //        int.TryParse(Console.ReadLine(), out firstArray[i, j]);
            //    }
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < Cols; j++)
            //    {
            //        secondArray[i, j] = firstArray[i, j];
            //    }
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < Cols; j++)
            //    {
            //        Console.Write($"{secondArray[i, j]}");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q28 Write a Program to Print One Dimensional Array in Reverse Order
            //int[] Nums = new int[] { 1, 6, 7, 1, 4, 7 };

            //for (int i = Nums.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($"{Nums[i]} ");
            //}
            #endregion

            /*Functions*/
            #region Q1 Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            /**
             * Pass by value:
             * when you pass variable by value u just copy the value of it and use it
             * any modifying doesn't change original value
             */

            //int x = 5, y = 10;
            //Swaps_PassByValue(x, y);
            //Console.WriteLine($"x = {x} and  y = {y}"); //5  10

            ///**
            // * Pass by Ref:
            // * it doesn't make a variable in function stack frame
            // * it only refer to the original address of variables 
            // * any modifying change original value
            // */

            //Swaps_PassByReference(ref x, ref y);
            //Console.WriteLine($"x = {x} and  y = {y}"); //10  5
            #endregion
        }

        /* ----------------Functions ---------------*/
    }
}
