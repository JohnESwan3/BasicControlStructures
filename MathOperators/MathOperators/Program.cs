// See https://aka.ms/new-console-template for more information

// Basic Assignment Operator
int num = 5;

// Arithmetic Operators
int num1 = 11;
int num2 = 12;

Console.WriteLine($"Addition: {num1 + num2}");
Console.WriteLine($"Subtraction: {num1 - num2}");
Console.WriteLine($"Multiplication: {num1 * num2}");
Console.WriteLine($"Division: {num1 / num2}");
Console.WriteLine($"Modulus: {num1 % num2}"); // Remainder after division

num1 = num1 + 4;
Console.WriteLine($"New Addition: {num1 + num2}");
Console.WriteLine($"New Subtraction: {num1 - num2}");
Console.WriteLine($"New Multiplication: {num1 * num2}");
Console.WriteLine($"New Division: {num1 / num2}");
Console.WriteLine($"New Modulus: {num1 % num2}");

// Compound Assignment Operators
num1 += 4; // Increase num1 by 4 and reasign
