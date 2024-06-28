using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _28._6._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //string[] ARR = { "1", "7", "9", "45" };
            //int[] arr2 = { 1, 2, 3 };
            //string[] arr3 = { "the", "fox", "over", "lazy", "dog" };

            //2
            //String[] fruits = { "Tomato", "Banana", "Watermelon" };
            //int inbanana = Array.IndexOf(fruits, "Banana");
            //int intomato = Array.IndexOf(fruits, "Tomato");
            //Console.WriteLine(inbanana);
            //Console.WriteLine(intomato);

            //3
            //Console.WriteLine("These are my fav food :");
            //string[] foodArr = { "fruits", "vegs" };
            //for (int i = 0; i < foodArr.Length; i++)
            //{
            //    Console.WriteLine(foodArr[i]);
            //}
            //Console.WriteLine("These are my fav sport:");
            //string[] sportArr2 = { "walking", "tennis", "running", "vollyball" };
            //for (int x = 0; x < sportArr2.Length; x++)
            //{
            //    Console.WriteLine(sportArr2[x]);
            //}

            //Console.WriteLine("These are my fav movies:");
            //string[] moviesArr3 = { "Cast Away", "Green Mile", "The Shawshank Redemption", "Dead Poets Society" };
            //foreach (string z in moviesArr3)
            //{
            //    Console.WriteLine(z);
            //}

            //4
            //int fstNo, secNo, thirdNo;
            //string[] nums = Console.ReadLine().Split(',');
            //fstNo = int.Parse(nums[0]);
            //secNo = int.Parse(nums[1]);
            //thirdNo = int.Parse(nums[2]);
            //int sum = fstNo + secNo + thirdNo;
            //Console.WriteLine(sum);

            //5
            //for (int i = 1; i <= 10; i = i + 2)

            //int n = 50; 
            //int i = 1;
            //int sum = 0;

            //Console.WriteLine("The odd numbers are:");

            //while (i <= n * 2)
            //{
            //    Console.Write(i + " ");
            //    sum += i;
            //    i += 2;
            //}

            //Console.WriteLine("The Sum of odd Numbers is: " + sum);

            //5
            //int rows = 4; // 

            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int j = 1; j <= rows - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= 2 * i - 1; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

                //6
                int rows = 4; 

                int number = 1; 

                for (int i = 1; i <= rows; i++)
                {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                    {
                        Console.Write(number + " ");
                        number++; 
                    }
                    Console.WriteLine();
                }
        }
    }
}


