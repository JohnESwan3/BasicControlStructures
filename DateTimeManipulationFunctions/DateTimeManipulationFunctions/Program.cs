// See https://aka.ms/new-console-template for more information
using System.Globalization;
// Empty DateTime

using System.Globalization;

DateTime date = new DateTime();

// Create a DateTime from date and time
DateTime dateOfBirth = new DateTime(1994, 11, 01);
Console.WriteLine($"My DOB is {dateOfBirth}");

// Create a DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine($"The time is {now}");

// Create a DateTime from a String
DateTime dateFromString = DateTime.Parse("1/31/2022", CultureInfo.InvariantCulture); // Needs System.Globalization
Console.WriteLine($"Date From String is {dateFromString}");

// Add Additional Time
Console.WriteLine("One hour from now is " + now.AddHours(1) );

// DateTime from Ticks
Console.WriteLine("Time as a numeral: " + now.Ticks);

// Date Only
DateOnly dateOnlyOfBirth = DateOnly.FromDateTime(dateOfBirth);
Console.WriteLine($"{dateOnlyOfBirth}");

// Time Only
TimeOnly timeOnly = TimeOnly.FromDateTime(now);
Console.WriteLine(timeOnly);