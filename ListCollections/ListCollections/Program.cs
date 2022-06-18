// See https://aka.ms/new-console-template for more information

// Lists are collections that aren't fixed to a set size

// Declare a list
List<string> names = new List<string>();
string name = string.Empty;

// Add values to list
/*
names[0] = "TestName"; // More dangerous to define the space
names.Add("John"); // Add to the end of list
names.Remove("John"); // Remove an item from list - everything is re-ordered
*/

Console.WriteLine("Enter Names");
// while (name != "-1")
// while (name.Equals("-1") == false)
while(!name.Equals("-1"))
{
    Console.Write("Enter Name: "); // Ask user for name
    name = Console.ReadLine(); // Get name from user
    
    // If name is not empty or equal to -1
    if (!string.IsNullOrEmpty(name) && !name.Equals("-1"))
    {
        Console.WriteLine($"{name} was added successfully.");
        names.Add(name); // Add user input (name) to list (names)
    }
}

// Print Values in list
Console.WriteLine("Printing Names via for loop");
for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}

// For Each -- Usually better
Console.WriteLine("Print Names via foreach loop");
foreach (string item in names)
{
    Console.WriteLine(item);
}