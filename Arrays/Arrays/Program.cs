// See https://aka.ms/new-console-template for more information

// Declare Fixed Size Array

using System.Security.Cryptography;

int[] grades = new int[5]; // Reserve 5 spaces 

// Add Values to Fixed Size Array

/*
grades[0] = 1;
grades[1] = 25;
grades[2] = 38;
grades[3] = 45;
grades[4] = 54;

grades = new int[] { 1, 25, 38, 45, 54 };
*/

// Loop through the array until the end
for (int i = 0; i < grades.Length; i++)
{
   // User assigns grade to each item in array
   Console.Write("Enter Grade: ");
   grades[i] = Convert.ToInt32(Console.ReadLine());
}

// Print Values in Fixed Size Array
Console.WriteLine("The Grades you have entered are");
for (int i = 0; i < grades.Length; i++)
{
   Console.WriteLine(grades[i]);
}

// Declare Variable Sized Array
   // Variables always have to have a size
string[] studentNames = new string[]{"Test", "Student1", "Student2"};

// Add Values to Variable Sized Array
Console.WriteLine("Enter All Names");
for (int i = 0; i < studentNames.Length; i++)
{
   Console.Write("Enter Name: ");
   studentNames[i] = Console.ReadLine();
}

// Print Values in Variable Sized Array
Console.WriteLine("The Names you have entered are: ");
for (int i = 0; i < studentNames.Length; i++)
{
   Console.WriteLine(studentNames[i]);
}