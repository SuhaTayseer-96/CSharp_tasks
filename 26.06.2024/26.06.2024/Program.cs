using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _26._06._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*First*/
            //Console.Write("Enter first int: ");
            //int fstNo = int.Parse(Console.ReadLine()); /*Parse : is used to convert a string representation of a number into an integer.*/

            //Console.Write("Enter sec int: ");
            //int secNo = int.Parse(Console.ReadLine());

            //int smallerNo = (fstNo < secNo) ? fstNo : secNo;  /* ? ternary conditional operator ? is used to compare the two numbers*/

            //Console.WriteLine("smaller No is: " + smallerNo);

            ///**********************************************************/
            ///*Second*/
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int theSign = Math.Sign(num);
            string[] signs = { "-", "0", "+" };
            string sign = signs[theSign + 1];
            Console.WriteLine("The sign is " + sign);
            ///**********************************************************/
            ///*Third*/
            int[] intager = new int[3];
            Console.WriteLine("add num :");
            intager[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("add num :");
            intager[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("add num :");
            intager[2] = int.Parse(Console.ReadLine());
            Array.Sort(intager);
            Console.Write("The sorted numbers are :");
            Console.WriteLine($"{intager[0]} {intager[1]} {intager[2]} ");

            /**********************************************************/
            /*Fourth*/
            int[] value = new int[5];
            Console.WriteLine("Enter 5 numbers: ");
            value[0] = int.Parse(Console.ReadLine());
            value[1] = int.Parse(Console.ReadLine());
            value[2] = int.Parse(Console.ReadLine());
            value[3] = int.Parse(Console.ReadLine());
            value[4] = int.Parse(Console.ReadLine());
            int maxValue = value.Max();
            Console.WriteLine("The maximum value is : " + maxValue);

            /**********************************************************/
            /*Fifth*/
            //Console.Write("Enter kilometers per hour: ");
            //double kmPerHour = double.Parse(Console.ReadLine());
            //double milesPerHour = kmPerHour * 0.621371;

            //Console.WriteLine($"{kmPerHour} kilometers per hour = {milesPerHour} miles per hour");


            /**********************************************************/
            /*sixth*/
            //Console.Write("Enter hours: ");
            //int hr = int.Parse(Console.ReadLine());

            //Console.Write("Enter mins: ");
            //int mins = int.Parse(Console.ReadLine());

            //int totalHrMin = hr * 60 + mins;
            //Console.WriteLine("Total: {0} minutes.", totalHrMin);

            /**********************************************************/
            /*7th*/
            //Console.Write("Enter mins: ");
            //int ttlMins = int.Parse(Console.ReadLine());

            //int hrs = ttlMins / 60;
            //int mins = ttlMins % 60;

            //Console.WriteLine($"{ttlMins} minutes = {hrs} Hours, {mins} Minutes");

            /**********************************************************/
            /*8th*/
                string[] elementWord = { "A heart adrift on seas of sorrow", "Longing for a gentle touch,", "Yearning for a hopeful morrow", "Yet bound by memories clutch"};
                Console.WriteLine(elementWord[0].Substring(0, 3));
                Console.WriteLine(elementWord[1].Substring(0, 3));
                Console.WriteLine(elementWord[2].Substring(0, 3));
                Console.WriteLine(elementWord[3].Substring(0, 3));
                Console.WriteLine(elementWord[4].Substring(0, 3));
                /**********************************************************/
            }
    }
}
