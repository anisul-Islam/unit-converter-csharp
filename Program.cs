string inputValue;
double value, convertedValue;

Console.WriteLine($"Welcome to the unit converter App");
Console.WriteLine($"\nAvailable Conversions:");

// Kilometers to Miles
Console.WriteLine($"Kilometers to Miles");
Console.Write($"Enter the value you want to convert: ");
inputValue = Console.ReadLine();
value = Convert.ToDouble(inputValue);
convertedValue = value * 0.621371;
Console.WriteLine($"{value} Kilometers = {convertedValue:F2} Miles");


Console.WriteLine($"\n\nMiles to Kilometers");
Console.Write($"Enter the value you want to convert: ");
inputValue = Console.ReadLine();
value = Convert.ToDouble(inputValue);
convertedValue = value / 0.621371;
Console.WriteLine($"{value} Miles = {convertedValue:F2} Kilometers");




