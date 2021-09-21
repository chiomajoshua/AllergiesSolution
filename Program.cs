using AllergiesSolution.Core;
using System;

namespace AllergiesSolution
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var allergy = new Allergies("Mark");
            Console.WriteLine(allergy.ToString());

            var scoreAllergy = new Allergies("Dorcas", 82);            
            Console.WriteLine(scoreAllergy.ToString());

            var descriptionAllergy = new Allergies("Dorcas", "Peanuts Chocolate Cats Strawberries");
            Console.WriteLine(descriptionAllergy.ToString());

            Console.ReadKey();
        }
    }
}