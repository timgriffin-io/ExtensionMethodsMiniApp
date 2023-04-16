namespace ConsoleUILibrary.ExtensionMethods;

public static class ConsoleExtensions
{
    public static string RequestString(this string message)
    {
        string output = "";

        while (string.IsNullOrWhiteSpace(output))
        {
            Console.Write(message);
            output = Console.ReadLine();
        }

        return output;
    }
    public static int RequestInt(this string message, int minValue, int maxValue)
        => message.RequestInt(true, minValue, maxValue);

    public static int RequestInt(this string message)
        => message.RequestInt(false);

    private static int RequestInt(this string message, bool useMinMax, int minValue = 0, int maxValue = 0)
    {
        int output = 0;
        bool isValid = false;
        bool isInMinMaxRange = true;

        while (isValid == false || isInMinMaxRange == false)
        {
            Console.Write(message);
            isValid = int.TryParse(Console.ReadLine(), out output);
            if (useMinMax == true)
            {
                isInMinMaxRange = output >= minValue && output <= maxValue;
            }
        }

        return output;
    }

}