using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
    public static class Day7
    {
        public static void PrintMulti()
    {
        for(byte i=1;i<=12;i++)
        {
            Console.WriteLine();
            Console.WriteLine($"=====Multi {i}=====");
            Console.WriteLine();
            for (byte j=1;j<=12;j++)
            {
                Console.WriteLine();
                Console.WriteLine($"{i} * {j} = {i*j}");
            }
        }
    }   public static bool IsContainDigit(string s)
    {
        if (s == null)
            return true;

        for(int i=0;i<s.Length;i++)
        {
            // 48==> 0 , 57==>9

            if ((int)s[i] <= 57 && (int)s[i] >= 48)
                return true;
        }
        return false;
    }
    public static void ReadData()
    {
        int ID,Salary;
        string Name="";
        do
        {
            Console.Write("please enter Your ID as a posititve number: ");
        } while (!int.TryParse(Console.ReadLine(), out ID) || ID<=0);

        do
        {
            Console.Write("please enter Your Name without any number: ");
            Name = Console.ReadLine();
        } while (string.IsNullOrEmpty( Name) || IsContainDigit(Name) );



        do
        {
            Console.Write("please enter Your Salary as a posititve number: ");
        } while (!int.TryParse(Console.ReadLine(), out Salary) || ID <= 0);

        Console.WriteLine(Name + " with ID: " + ID + " has a salary of: " + Salary + "");
    }
    public static void ArrayDegree()
    {
        int size;
        int MaxDegree,MinimumDegree;
        int deg;

        do
        {
            Console.Write("please enter the degree of array: ");
        } while (!int.TryParse(Console.ReadLine(), out size) || size <= 0);
        
        int[] arr= new int[size];
        // read first degree 
        do
        {
            Console.Write($"please enter the degree of index {0}: ");
        } while (!int.TryParse(Console.ReadLine(), out deg) || deg < 0);

        arr[0]  = deg;
        MaxDegree = deg;// only assume
        MinimumDegree= deg;
        for (int i=1;i<size;i++)
        {
            
            do
            {
                Console.Write($"please enter the degree of index {i}: ");
            } while (!int.TryParse(Console.ReadLine(), out deg) || deg < 0);
            if(MaxDegree<deg)
            {
                MaxDegree = deg;
            }
            if(MinimumDegree>deg)
            {
                MinimumDegree=deg;
            }
                
        }
        Console.WriteLine($"The Maximum degree {MaxDegree}");
        Console.WriteLine($"The Minimum degree {MinimumDegree}");
    }
}
