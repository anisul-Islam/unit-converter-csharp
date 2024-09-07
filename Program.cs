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

switch ((option, value))
{
  case (1, var valueFromUser):
    convertedValue = valueFromUser * 0.621371;
    Console.WriteLine($"{valueFromUser} Kilometers = {convertedValue:F2} Miles");
    break;
  case (2, var valueFromUser):
    // Miles to Kilometers
    convertedValue = valueFromUser / 0.621371;
    Console.WriteLine($"{valueFromUser} Miles = {convertedValue:F2} Kilometers");
    break;
  case (3, var valueFromUser):
    //Celsius to Fahrenheit
    convertedValue = (valueFromUser * 1.8) + 32;
    Console.WriteLine($"{valueFromUser} Celsius = {convertedValue:F2} Fahrenheit");
    break;
  case (4, var valueFromUser):
    // Fahrenheit to Celsius
    convertedValue = (valueFromUser - 32) / 1.8;
    Console.WriteLine($"{valueFromUser} Fahrenheit = {convertedValue:F2} Celsius");
    break;
  case (5, var valueFromUser):
    // kilograms to pounds
    convertedValue = valueFromUser * 2.20462; // 1 kilogram = 2.20462 pounds
    Console.WriteLine($"{valueFromUser} kilograms = {convertedValue:F2} Pounds");
    break;
  case (6, var valueFromUser):
    // Pounds to kilograms
    convertedValue = valueFromUser / 2.20462; // 1 Pound = 0.453592 kilograms
    Console.WriteLine($"{valueFromUser} Pounds = {convertedValue:F2} kilograms");
    break;
  default:
    Console.WriteLine($"Invalid Selection. Please run the program again."); break;

}









