using System;
using System.Collections.Generic;
using System.Linq;
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

            /**********************************************************/
            /*Second*/
            /*Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("The sign is +");
            }
            else if (number < 0)
            {
                Console.WriteLine("The sign is -");
            }
            else
            {
                Console.WriteLine("The sign is 0");
            }*/
            /**********************************************************/
            /*Third*/
            /*Console.Write("Enter the first number: ");
            int no1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int no2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int no3 = int.Parse(Console.ReadLine());

            int temp;

            if (no1 > no2)
            {
                temp = no1;
                no1 = no2;
                no2 = temp;
            }

            if (no1 > no3)
            {
                temp = no1;
                no1 = no3;
                no3 = temp;
            }

            if (no2 > no3)
            {
                temp = no2;
                no2 = no3;
                no3 = temp;
            }

            Console.WriteLine($"Numbers in ascending order: {no1}, {no2}, {no3}");*/

            /**********************************************************/
            /*Fourth*/
            /*Console.WriteLine("Enter five numbers:");

            int no1 = int.Parse(Console.ReadLine());
            int no2 = int.Parse(Console.ReadLine());
            int no3 = int.Parse(Console.ReadLine());
            int no4 = int.Parse(Console.ReadLine());
            int no5 = int.Parse(Console.ReadLine());

            int maxNo = no1;

            maxNo = (no2 > maxNo) ? no2 : maxNo;
            maxNo = (no3 > maxNo) ? no3 : maxNo;
            maxNo = (no4 > maxNo) ? no4 : maxNo;
            maxNo = (no5 > maxNo) ? no5 : maxNo;
            Console.WriteLine("maximum no is: " + maxNo);*/

            /**********************************************************/
            /*Fifth*/
            /*Console.Write("Enter kilometers per hour: ");
            double kmPerHour = double.Parse(Console.ReadLine());
            double milesPerHour = kmPerHour * 0.621371;

            Console.WriteLine($"{kmPerHour} kilometers per hour = {milesPerHour} miles per hour");*/


            /**********************************************************/
            /*sixth*/
            /*Console.Write("Enter hours: ");
            int hr = int.Parse(Console.ReadLine());

            Console.Write("Enter mins: ");
            int mins = int.Parse(Console.ReadLine());

            int totalHrMin = hr * 60 + mins;
            Console.WriteLine("Total: {0} minutes.", totalHrMin);*/

            /**********************************************************/
            /*7th*/
            /*Console.Write("Enter mins: ");
            int ttlMins= int.Parse(Console.ReadLine());

            int hrs = ttlMins / 60;
            int mins = ttlMins % 60;

            Console.WriteLine($"{ttlMins} minutes = {hrs} Hours, {mins} Minutes");*/

            /**********************************************************/
            /*8th*/
            string[] sentences = {
            "A heart adrift on seas of sorrow,",
            "Longing for a gentle touch,",
            "Yearning for a hopeful morrow,",
            "Yet bound by memories clutch.",
        };
            for (int i = 0; i < sentences.Length; i++)
            {
                string sentence = sentences[i];
                Console.WriteLine($"{sentence} // {sentence.Length} characters");
                /**********************************************************/
            }
            }
    }
}
