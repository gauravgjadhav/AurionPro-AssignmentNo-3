using System;
class Overloading
{
    public static void Main(string[] args)
    {

        string[] names = { "gaurav", "jadhav" };
        PrintDetails(names);

        int[] marks = { 10, 40, 55 };
        PrintDetails(marks);

        char[] symbols = {'@','$','%'};
        PrintDetails(symbols);

        float[] input = {1,2,3};
        PrintDetails(input);

        double[] inputs = { 1.2, 1.3 };
        PrintDetails(inputs);

    }

    static void PrintDetails(string[] names)
    {
        Console.WriteLine("overload 1 name");
        foreach (string ch in names)
        {
            
            Console.WriteLine(ch);
        }

        
    }
    static void PrintDetails(int[] marks)
    {
        Console.WriteLine("overload 2 marks");
        foreach (int mark in marks)
        {
            
            Console.WriteLine(mark);
        }
    }
    static void PrintDetails(char[] symbols)
    {
        Console.WriteLine("Overloads 3 for Symboles");
        foreach(char ch in symbols)
        {
            Console.WriteLine(symbols);
        }
    }
    static void PrintDetails(float[] input)
    {
        Console.WriteLine("overlods 4 for floating");
        foreach(float flt in input)
        {
            Console.WriteLine(flt);

        }
    }
    static void PrintDetails(double[] inputs)
    {
        Console.WriteLine("overloads 5 for double");
        foreach(double dbl in inputs)
        {
            Console.WriteLine(dbl);
        }

    }

    
  
}
