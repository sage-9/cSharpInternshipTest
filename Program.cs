namespace cSharpInternshipTest;

class Program
{
    static void Main(string[] args)
    {
        //Task 1
        string name = "John Doe";
        int age = 25;
        bool isAdmin=true;
        
        Console.WriteLine(name);
        Console.WriteLine(age);
        Console.WriteLine(isAdmin);
        Console.WriteLine("\n\n\n");
        
        //Task 2
        Console.WriteLine("enter a number");
        int number =Convert.ToInt32(Console.ReadLine());
        bool isEven = number % 2 == 0;
        if (isEven) Console.WriteLine("Even");
        else Console.WriteLine("Odd");
        Console.WriteLine("\n\n\n");
        
        //Task 3
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i);   
        }
        Console.WriteLine("\n\n\n");
        
        //Task 4
        int[] array = new[] {2,4,6,8,10};
        foreach (int num in array)
        {
            Console.WriteLine(num);
            
        }
        Console.WriteLine("\n\n\n");
        
        //Task 5
        Greet("Alice");
        Console.WriteLine("\n\n\n");
    }
    static void Greet(string name)
    {
        Console.WriteLine($"Hello, {name} !");
    }
}