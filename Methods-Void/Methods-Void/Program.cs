// Prototype : Defines the function (type, name and parameters) 
// Definition : Has the code. It contains the code block
// Function Call - Makes the function execute

// DRY - Don't Repeat Yourself
// YAGNI - You Arn't Going To Need It : Don't write code you don't need

// Void Functions : Completes a task and moves along
void PrintName()
{
    Console.WriteLine("John");
}

void Addition(int num1, int num2)
{
    Console.WriteLine($"The Sum of {num1} and {num2} is {num1 + num2}");
}


// Value Returning Functions : Completes a task, returns a result

PrintName();
Console.WriteLine("Enter a number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter another number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Addition(number1, number2);