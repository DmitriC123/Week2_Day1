using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int favoriteNumber = 12;
            //int[] favoriteNumbers = { 61, 22, 3, 44, 105, 36 };

            //string[] studentNames = { "Raz", "Monica", "David", "Brian", "Ali", };

            //Console.WriteLine(favoriteNumber);
            //Console.WriteLine(favoriteNumbers[0]);
            //Console.WriteLine(studentNames[2]);

            //string[] vacationSpots = { "Mexico", "Puerto Rico", "Russia", "Hawaii", "Antarctica", "Spain", "Italy",
            //    "France", "England", "Ireland" };
            //Console.WriteLine(vacationSpots[0]+ " " + vacationSpots[9]);

            //int[] childAges = { 7, 4, 2, 5, 9 };
            //Console.WriteLine(childAges[0]);
            //Console.WriteLine(childAges[1]);
            //Console.WriteLine(childAges[2]);

            //double[] studentGPAs = { 2.0, 3.1, 3.2, 2.5, 2.8, 2.9, 3.0, 3.5 };
            //Console.WriteLine(studentGPAs[0]);
            //Console.WriteLine(studentGPAs[1]);
            //Console.WriteLine(studentGPAs[2]);
            //Console.WriteLine(studentGPAs[3]);
            //Console.WriteLine(studentGPAs[4]);
            //Console.WriteLine(studentGPAs[5]);
            //Console.WriteLine(studentGPAs[6]);
            //Console.WriteLine(studentGPAs[7]);

            //string[] firstLetter = {"N", "B", "R", "D" };
            //Console.WriteLine(firstLetter[0] + " " + firstLetter[1] + " " + firstLetter[2] + " " + firstLetter[3]);

            //int[] numbers = new int[4];
            //numbers[0] = 43;
            //numbers[1] = 12;
            //Console.WriteLine("Please enter a number.");
            //numbers[2] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter a number.");
            //numbers[3] = int.Parse(Console.ReadLine());
            //Console.WriteLine(numbers[0] + " " + numbers[1] + " " + numbers[2] + " " + numbers[3]);

            //string[] daysofWeek = new string[7];
            //daysofWeek[0] = "Sun";
            //daysofWeek[1] = "Mon";
            //daysofWeek[2] = "Tues";
            //daysofWeek[3] = "Wed";
            //daysofWeek[4] = "Thurs";
            //daysofWeek[5] = "Fri";
            //daysofWeek[6] = "Sat";

            //int[] studentAges = new int[4];
            //studentAges[0] = 12;
            //studentAges[1] = 16;
            //studentAges[2] = 12;
            //studentAges[3] = 8;

            //Console.WriteLine(daysofWeek.Length);

            //char[] lastName = { 'C', 'o', 'h', 'a', 'n' };
            //Console.WriteLine(lastName.Length);


            //Declare and initialize a string array. Using the Length property, 
            //print the second to last element in the array.

            string[] exampleStringArray = { "This", "is", "an", "array", "of", "words", "because", "I", "like", "words" };

            //Console.WriteLine("This is the last index " + (exampleStringArray.Length - 1));

            Console.WriteLine(exampleStringArray[exampleStringArray.Length - 1]);

            //int index = exampleStringArray.Length;
            //index = index - 2;

            //Console.WriteLine(exampleStringArray[index]);

        }
    }
}
