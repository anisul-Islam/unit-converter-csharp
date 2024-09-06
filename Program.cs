string? inputValue;
double value, convertedValue;

Console.WriteLine($"Welcome to the unit converter App");
Console.WriteLine($"\nAvailable Conversions:");

// Kilometers to Miles
Console.WriteLine($"1. Kilometers to Miles");
Console.Write($"Enter the value you want to convert: ");
inputValue = Console.ReadLine();
value = Convert.ToDouble(inputValue);
convertedValue = value * 0.621371;
Console.WriteLine($"{value} Kilometers = {convertedValue:F2} Miles");


// Miles to Kilometers
Console.WriteLine($"\n\n2. Miles to Kilometers");
Console.Write($"Enter the value you want to convert: ");
inputValue = Console.ReadLine();
value = Convert.ToDouble(inputValue);
convertedValue = value / 0.621371;
Console.WriteLine($"{value} Miles = {convertedValue:F2} Kilometers");


//Celsius to Fahrenheit
Console.WriteLine($"\n\n3. Celsius to Fahrenheit.");
Console.Write($"Enter the value you want to convert: ");
inputValue = Console.ReadLine();
value = Convert.ToDouble(inputValue);
convertedValue = (value * 1.8) + 32;
Console.WriteLine($"{value} Celsius = {convertedValue:F2} Fahrenheit");

// Fahrenheit to Celsius
Console.WriteLine($"\n\n4. Fahrenheit to Celsius");
Console.Write($"Enter the value you want to convert: ");
inputValue = Console.ReadLine();
value = Convert.ToDouble(inputValue);
convertedValue = (value - 32) / 1.8;
Console.WriteLine($"{value} Fahrenheit = {convertedValue:F2} Celsius");

// kilograms to pounds
Console.WriteLine($"\n\n5. kilograms to pounds");
Console.Write($"Enter the value you want to convert: ");
inputValue = Console.ReadLine();
value = Convert.ToDouble(inputValue);
convertedValue = value * 2.20462; // 1 kilogram = 2.20462 pounds
Console.WriteLine($"{value} kilograms = {convertedValue:F2} Pounds");

// Pounds to kilograms
Console.WriteLine($"\n\n6. Pounds to kilograms");
Console.Write($"Enter the value you want to convert: ");
inputValue = Console.ReadLine();
value = Convert.ToDouble(inputValue);
convertedValue = value / 2.20462; // 1 Pound = 0.453592 kilograms
Console.WriteLine($"{value} Pounds = {convertedValue:F2} kilograms");




