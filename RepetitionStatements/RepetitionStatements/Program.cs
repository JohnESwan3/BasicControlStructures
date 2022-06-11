// For Loop (Counter Controlled)
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Counter value: {i}");
}

// While Loop (Condition Controlled - Pre Check)
int n = 0;
while (n < 5)
{
    Console.WriteLine("Input a number: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You entered {n}");
}

// Do...While Loop (Inverted While Loop - Condition Controlled - Post Check)
int x = 0;
do
{
    Console.WriteLine("Input a number: ");
    x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You entered {x}");
} while (x < 10);

// Foreach - Usually for lists or collections
foreach (var item in collection)
{
    
}