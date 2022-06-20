using System;
class Program
{
    public static void Main(string[] args)
    {
        int sum = 0;
        for (int i = 0; i < args.Length; i++)
        {
            int n = Convert.ToInt32(args[i]);
            sum = sum + n;

        }
        Console.WriteLine("The sum of the number  " + sum);
        int avarage = sum / 4;
        Console.WriteLine("The Avarage Of Numbers  " + avarage);
        int maxvalue = 0;
        int minvalue = maxvalue;
        for (int i = 0; i < args.Length; i++)
        {
            int n1 = Convert.ToInt32(args[i]);
            if(maxvalue < n1)
            {
                maxvalue = n1;
                
            }
            if (minvalue > n1)
            {
                minvalue = n1;
                
            }
            
            
        }
        Console.WriteLine("The min Value in Array is:"+minvalue);
        
        Console.WriteLine("The Max Value in Arrau is:"+maxvalue);
    }
}