class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Calculator!");

        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Calculator calculator = new Calculator(num1, num2);
        Console.WriteLine("Select an operation:");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");
        Console.Write("Enter your choice (1-4): ");
        string choice = Console.ReadLine();
        try
        {
            double result = 0;
            switch (choice)
            {
                case "1":
                    result = calculator.Add();
                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
                    break;
                case "2":
                    result = calculator.Subtract();
                    Console.WriteLine($"Result: {num1} - {num2} = {result}");
                    break;
                case "3":
                    result = calculator.Multiply();
                    Console.WriteLine($"Result: {num1} * {num2} = {result}");
                    break;
                case "4":
                    result = calculator.Divide();
                    Console.WriteLine($"Result: {num1} / {num2} = {result}");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid operation.");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"⚠️ Error: {ex.Message}");
        }
    }
}