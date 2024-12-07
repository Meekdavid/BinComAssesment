class Program
{
    static void Main(string[] args)
    {
        // Task 1: Declare and initialize variables
        string name = "John Doe";
        int age = 25;
        bool isAdmin = true;
        Console.WriteLine($"Name: {name}, Age: {age}, Is Admin: {isAdmin}");

        // Task 2: Check if a number is even or odd
        Console.WriteLine("\nEnter an integer:");
        int userInput = int.Parse(Console.ReadLine());
        if (userInput % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }

        // Task 3: Print numbers from 1 to 10
        Console.WriteLine("\nNumbers from 1 to 10:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // Task 4: Array operations
        int[] numbers = { 2, 4, 6, 8, 10 };
        int sum = 0;
        Console.WriteLine("\nArray elements:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
            sum += num;
        }
        Console.WriteLine($"Sum of array elements: {sum}");

        // Task 5: Greet method
        Greet("Alice");
    }

    // Task 5: Greet method
    static void Greet(string name)
    {
        Console.WriteLine($"\nHello, {name}!");
    }
}
