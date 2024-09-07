string? inputValue;
double value, convertedValue;

Console.WriteLine($"Welcome to the unit converter App");
Console.WriteLine($"\nAvailable Conversions:");
Console.WriteLine($"1. Kilometers to Miles");
Console.WriteLine($"2. Miles to Kilometers");
Console.WriteLine($"3. Celsius to Fahrenheit.");
Console.WriteLine($"4. Fahrenheit to Celsius");
Console.WriteLine($"5. kilograms to pounds");
Console.WriteLine($"6. Pounds to kilograms");
int option = Convert.ToInt32(Console.ReadLine());

Console.Write($"Enter the value you want to convert: ");
inputValue = Console.ReadLine();
value = Convert.ToDouble(inputValue);

if (option == 1)
{
  // Kilometers to Miles
  convertedValue = value * 0.621371;
  Console.WriteLine($"{value} Kilometers = {convertedValue:F2} Miles");
}
else if (option == 2)
{
  // Miles to Kilometers
  convertedValue = value / 0.621371;
  Console.WriteLine($"{value} Miles = {convertedValue:F2} Kilometers");
}
else if (option == 3)
{
  //Celsius to Fahrenheit
  convertedValue = (value * 1.8) + 32;
  Console.WriteLine($"{value} Celsius = {convertedValue:F2} Fahrenheit");
}
else if (option == 4)
{
  // Fahrenheit to Celsius
  convertedValue = (value - 32) / 1.8;
  Console.WriteLine($"{value} Fahrenheit = {convertedValue:F2} Celsius");
}
else if (option == 5)
{
  // kilograms to pounds
  convertedValue = value * 2.20462; // 1 kilogram = 2.20462 pounds
  Console.WriteLine($"{value} kilograms = {convertedValue:F2} Pounds");
}
else if (option == 6)
{
  // Pounds to kilograms
  convertedValue = value / 2.20462; // 1 Pound = 0.453592 kilograms
  Console.WriteLine($"{value} Pounds = {convertedValue:F2} kilograms");
}
else
{
  Console.WriteLine($"Invalid Selection. Please run the program again.");
}












