using AllergiesSolution.Core;
using System;
using static AllergiesSolution.Core.Enums;

namespace AllergiesSolution
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var allergyService = new Allergies();
            
            //AddAllergy(string input)
            allergyService.AddAllergy("Tomatoes");
            Console.WriteLine($"Allergy Score is : { allergyService.Score}");
            
            //AddAllergy(enum input)
            allergyService.AddAllergy(Allergen.Cats);
            Console.WriteLine($"Allergy Score is : { allergyService.Score}");
            
            //DeleteAllergy(enum input)
            allergyService.DeleteAllergy(Allergen.Shellfish);
            Console.WriteLine($"Allergy Score is : { allergyService.Score}");
                
            //DeleteAllergy(string input)
            allergyService.DeleteAllergy("Peanuts");
            Console.WriteLine($"Allergy Score is : { allergyService.Score}");

            var allergy = new Allergies("Mark");
            Console.WriteLine(allergy.ToString());

            var scoreAllergy = new Allergies("Dorcas", allergyService.Score);            
            Console.WriteLine(scoreAllergy.ToString());

            var descriptionAllergy = new Allergies("Richie", "Peanuts Chocolate Cats Strawberries");
            Console.WriteLine(descriptionAllergy.ToString());

            Console.ReadKey();
        }
    }
}
