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

        }
    }
}
