using System;

namespace AllergiesSolution
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var obj = new Allergies("Mark", 82);
            var otherObj = new Allergies("Dorcas");
            Console.WriteLine(obj.ToString());
            Console.WriteLine(otherObj.ToString());
            Console.ReadKey();
        }
    }
}