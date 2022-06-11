using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    public static void Main(string[] args)
    {
        
        string s1 = args[0];
        string s2 = args[1];
        string s3 = args[2];
        string s4 = args[3];//Accessing values

        int n1 = int.Parse(s1);
        int n2 = int.Parse(s2);
        int n3 = int.Parse(s3);
        int n4 = int.Parse(s4);//converting string to integer

        int sum = n1 + n2 + n3 + n4;
        Console.WriteLine("Sum is:"+sum);//for sum of number
	
      int avarage=(sum)/4; 
      Console.WriteLine("Avarage is:"+avarage);//for avarage of number

      Console.WriteLine("Largest of four: "+Math.Max(n1, Math.Max(n2, n3,n4)));
     Console.WriteLine("Lowest of four: "+Math.Min(n1, Math.Min(n2, n3,n4)));//display min and max number


    }
}