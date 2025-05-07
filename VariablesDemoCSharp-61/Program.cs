namespace VariablesDemoCSharp_61;

class Program
{
    static void Main(string[] args)
    {
        //variables are containers that store information
        //variable names are camel case - thisIsAnExample
        
        //number types
        
        //declaring a variable (creation)

        int myAge;
        
        //initializing a variable (giving a value)

        myAge = 31;
        
        //or do both (declaring and initialzing)
        
        //type - name - value
        
        int year = 2025;

        double average = 99.8;
        
        decimal price = 1.20m;
        
        //word types

        char middleInitial = 'S';

        string email = "sbowman@truecoders.io";
        
        //fact type

        bool isCoding = true;
        
        //string interpolation

        // string message = $"This year is {year}. My email is {email}.";
        //
        // Console.WriteLine(message);

        //Console.WriteLine($"This year is {year}. My email is {email}.");
        
        //taking user input
        
        //step 1: prompt the user (tell them what you need)

        Console.WriteLine("What is your name?");
        
        //step 2: getting the user's response

        string userName = Console.ReadLine();
        
        //step 3: interpolate a string to the user using what they've given

        Console.WriteLine($"Hello, {userName}!");
    }
}
