
// Void Functions
void PrintName()
{
    Console.WriteLine("John");
}

void Addition(int num1, int num2)
{
    Console.WriteLine($"The sum of {num1} and {num2} is {num1+num2}");
}

// Value Returning Functions - Completes a task, returns a result
int LargestNumber(int num1, int num2, int num3)
{
    int largest = num1; // Assume the largest number
    // Check if num1 is largest, if not reasign it to largest number
    if (largest < num2)
    {
        largest = num2;
    }

    if (largest < num3)
    {
        largest = num3;
    }
    return largest;
}

PrintName();

Console.WriteLine("Enter a number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter another number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Addition(number1, number2);

Console.WriteLine("Enter number 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int result = LargestNumber(number1, number2, number3);
Console.WriteLine($"The Largest Number is: {result}");