using System;
//public class Person
//{
//    public int Age
//    {
//        get;
//        set;
//    } = 18;

//    public string Gender
//    {
//        get;
//        set;
//    } = "Unknown";

//    public string Name
//    {
//        get;
//        set;
//    } = "Unnamed";

//    public string Email
//    {
//        get;
//        set;
//    } = "unknown@example.com";

//    public string ID
//    {
//        get;
//        set;
//    } = "0000";

//    private string phone = "0770000000";
//    public string Phone
//    {
//        get { return phone; }
//        set
//        {
//            if (value.StartsWith("077") || value.StartsWith("078") || value.StartsWith("079"))
//            {
//                phone = value;
//            }
//            else
//            {
//                Console.WriteLine("Phone number must start with 077, 078, or 079.");
//            }
//        }
//    }
//    public void DisplayDetails()
//    {
//        Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}, Email: {Email}, ID: {ID}, Phone: {Phone}");
//    }
//}

namespace _30._06._2024
{
    internal class Program
    {
       public static void Main()
        {
            //1

            //int i, j, sum = 0;
            //double avg;

            //Console.Write("Input the 10 nums : \n");
            //for (i = 1; i <= 10; i++)
            //{
            //    Console.Write("Num-{0} :", i);

            //    j = Convert.ToInt32(Console.ReadLine());
            //    sum += j;
            //}

            //avg = sum / 10.0;

            //Console.Write("The sum of 10 numbers is : {0}\nThe Average is : {1}\n", sum, avg);

            //2    ===> main

            //Console.WriteLine("input nums");
            //int t = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= t; i++)
            //{
            //    int cube = i * i * i;
            //    Console.WriteLine($"Number is: {i} and cube of the {i} is: {cube}");
            //}
            //3
            //int[] years = new int[] { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };

            //foreach (int year in years)
            //{
            //    if (year > 1950)
            //    {
            //        Console.WriteLine(year);
            //    }
            //}

            //Console.WriteLine("==========================================================");
            //4 
            //    Console.Write("Enter your age in years: ");
            //    int ageInYears = Convert.ToInt32(Console.ReadLine());

            //    int ageInDays = CalculateAgeInDays(ageInYears);

            //    Console.WriteLine($"Your age in days is: {ageInDays}");
            //}

            //public static int CalculateAgeInDays(int ageInYears)
            //{
            //    return ageInYears * 365;

            //Console.WriteLine("==========================================================");

            //5
            //Person defaultPerson = new Person();
            //defaultPerson.DisplayDetails();

            //Person person = new Person
            //{
            //    Age = 28,
            //    Gender = "Female",
            //    Name = "Suha Tayseer",
            //    Email = "s.me@example.com",
            //    ID = "996200",
            //    Phone = "0790000000"
            //};
            //person.DisplayDetails();

        }
    }
}
