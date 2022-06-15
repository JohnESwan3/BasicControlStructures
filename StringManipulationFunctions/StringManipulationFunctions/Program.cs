// See https://aka.ms/new-console-template for more information

string firstName = "John";
string lastName = "Swan";
DateTime date = DateTime.Now;

// Print to screen
Console.WriteLine(firstName);
Console.WriteLine("String being printed");

// Concatenation
Console.WriteLine(firstName + " " + lastName);
Console.WriteLine("My full name is " + firstName + " " + lastName);
Console.WriteLine($"My full name is {firstName} {lastName}");
Console.WriteLine("My name is {0} {1}", firstName, lastName);

// String length
int length = firstName.Length;
Console.WriteLine($"Your name is {length} letters long");

// Replace string parts
string newName1 = firstName.Replace('n', 'm');
Console.WriteLine($"Your new name is {newName1}");

string newName2 = firstName.Replace('n', ' ');
Console.WriteLine($"Your newer name is {newName2}");

// Append to other string variable
string fullName = firstName + " " + lastName;
Console.WriteLine(fullName);

// Split String
string[] splitName = fullName.Split('o');
for (int i = 0; i < splitName.Length; i++)
{
    Console.WriteLine(splitName[i]);
}

string nullString = null; // Null
string emptyString = ""; // Empty
string whiteSpaceString = " ";

// Compare Strings
if (string.IsNullOrEmpty(nullString))
{
    Console.WriteLine("String is null");
}

if (firstName == lastName)
{
    Console.WriteLine("Names are equal");
}

int comparisonResult = string.Compare(firstName, lastName);
if (comparisonResult == 0)
{
    Console.WriteLine("Names are equal");
}
else
{
    Console.WriteLine("Names are not equal");
}

// Convert to String
string convertedString = string.Empty;
int number = 123456789;

convertedString = number.ToString();
// convertedString = 123456789.ToString(); Also able to do this