// See https://aka.ms/new-console-template for more information

// Variable Declarations and Types
string fullName = string.Empty;
int age;
double salary;
char gender;
bool working;

// Prompt user for input
Console.Write("Please Enter Your Name: ");
fullName = Console.ReadLine();

Console.Write("Please Enter Your Age: ");
// Convert input to an int
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please Enter Your Salary: ");
// Convert input to a double
salary = Convert.ToDouble(Console.ReadLine());

Console.Write("Please Enter Your Gender (M/F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are You Working (true or false): ");
working = Convert.ToBoolean(Console.ReadLine());

// Print Information
Console.WriteLine("Your name is " + fullName); // Concatenation
Console.WriteLine("Your age is: {0}", age);
Console.WriteLine($"Your salary is: {salary}"); // Interpolation
Console.WriteLine($"Your gender is: {gender}");
Console.WriteLine($"Are you employed?: {working}");