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

        }

        /* ----------------Functions ---------------*/
    }
}
