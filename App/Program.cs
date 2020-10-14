using System;

namespace NetCore.Docker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var x = "Systemline Written";
            Console.WriteLine(x);
            string s  = Environment.CurrentDirectory;  
            x = "Current Directory is: " + s;
            Console.WriteLine(x);
            string stemp2 = Environment.MachineName;
            Console.WriteLine("The name of this machine is :"+stemp2);
        }
    }
}
