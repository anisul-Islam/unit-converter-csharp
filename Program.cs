class UnitConverterApp
{

  static void DisplayMenu()
  {
    Console.WriteLine($"Welcome to the unit converter App");
    Console.WriteLine($"Available Conversions:");
    Console.WriteLine($"1. Kilometers to Miles");
    Console.WriteLine($"2. Miles to Kilometers");
    Console.WriteLine($"3. Celsius to Fahrenheit.");
    Console.WriteLine($"4. Fahrenheit to Celsius");
    Console.WriteLine($"5. kilograms to pounds");
    Console.WriteLine($"6. Pounds to kilograms");
    Console.Write($"Please select an option from 1-6: ");
  }

  static bool TryGetOption(out int option)
  {
    string? input = Console.ReadLine();
    if (int.TryParse(input, out option) && option >= 1 && option <= 6)
    {
      return true;
    }
    Console.WriteLine($"Only numeric value is allowed. Please select from option 1-6\n");
    return false;
  }

  static bool TryGetConversionValue(out double convertedValidValue)
  {
    Console.Write($"Enter the value you want to convert: ");
    string? inputValue = Console.ReadLine();
    try
    {
      if (string.IsNullOrWhiteSpace(inputValue))
      {
        throw new ArgumentException($"Input can not be empty.");
      }

      if (!double.TryParse(inputValue, out convertedValidValue) || convertedValidValue < 0)
      {
        throw new ArgumentException($"Only Positive numeric valus are allowed.");
      }

      if (convertedValidValue > double.MaxValue)
      {
        throw new ArgumentOutOfRangeException($"Warning: The value is too large and may not realistic.");
      }
      return true;
    }
    catch (ArgumentException ex)
    {
      Console.WriteLine($"Error : {ex.Message}");
    }
    convertedValidValue = 0;
    return false;
  }

  // Conversion methods
  static double ConvertKilometersToMiles(double kilometers) => kilometers * 0.621371;
  static double ConvertMilesToKilometers(double miles) => miles / 0.621371;
  static double ConvertCelsiusToFahrenheit(double celsius) => (celsius * 1.8) + 32;
  static double ConvertFahrenheitToCelsius(double fahrenheit) => (fahrenheit - 32) / 1.8;
  static double ConvertKilogramsToPounds(double kilograms) => kilograms * 2.20462;
  static double ConvertPoundsToKilograms(double pounds) => pounds / 2.20462;

  static void PerformConversion(int option, double convertedValue)
  {
    switch ((option, convertedValue))
    {
      case (1, var valueFromUser):
        convertedValue = ConvertKilometersToMiles(valueFromUser);
        Console.WriteLine($"{valueFromUser} Kilometers = {convertedValue:F2} Miles");
        break;
      case (2, var valueFromUser):
        // Miles to Kilometers
        convertedValue = ConvertMilesToKilometers(valueFromUser);
        Console.WriteLine($"{valueFromUser} Miles = {convertedValue:F2} Kilometers");
        break;
      case (3, var valueFromUser):
        //Celsius to Fahrenheit
        convertedValue = ConvertCelsiusToFahrenheit(valueFromUser);
        Console.WriteLine($"{valueFromUser} Celsius = {convertedValue:F2} Fahrenheit");
        break;
      case (4, var valueFromUser):
        // Fahrenheit to Celsius
        convertedValue = ConvertFahrenheitToCelsius(valueFromUser);
        Console.WriteLine($"{valueFromUser} Fahrenheit = {convertedValue:F2} Celsius");
        break;
      case (5, var valueFromUser):
        // kilograms to pounds
        convertedValue = ConvertKilogramsToPounds(valueFromUser);
        Console.WriteLine($"{valueFromUser} kilograms = {convertedValue:F2} Pounds");
        break;
      case (6, var valueFromUser):
        // Pounds to kilograms
        convertedValue = ConvertPoundsToKilograms(valueFromUser);
        Console.WriteLine($"{valueFromUser} Pounds = {convertedValue:F2} kilograms");
        break;
      default:
        Console.WriteLine($"Invalid Selection. Please run the program again."); break;
    }

  }
  public static void Main(string[] args)
  {
    while (true)
    {
      DisplayMenu();

      if (!TryGetOption(out int option))
      {
        continue;
      }

      if (!TryGetConversionValue(out double convertedValue))
      {
        Console.WriteLine($"Input can not be empty. Please enter a valid numeric value");
        continue;
      }
      PerformConversion(option, convertedValue);
      break;
    }
  }
}