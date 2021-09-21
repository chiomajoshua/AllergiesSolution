using System;
using static AllergiesSolution.Enums;

namespace AllergiesSolution
{
    public class Allergies
    {
        public string Name;
        public int Score = 0;
        public string Description;

        public Allergies()
        {

        }

        public Allergies(string name)
        {
            Name = name;            
        }

        public Allergies(string name, int score)
        {
            Name = name;
            Score = score;           
        }

        public Allergies(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void AddAllergy(string allergen)
        {            
            if(Utilities.IsAllergicTo(allergen))
                Score += (int)Enum.Parse(typeof(Allergen), allergen);
        }

        public void AddAllergy(Allergen allergen)
        {
            if(Utilities.IsAllergicTo(allergen))
                Score += (int)allergen;
        }

        public void DeleteAllergy(string allergen)
        {
            if (Utilities.IsAllergicTo(allergen))
                Score -= (int)Enum.Parse(typeof(Allergen), allergen);
        }

        public void DeleteAllergy(Allergen allergen)
        {
            if (Utilities.IsAllergicTo(allergen))
                Score -= (int)allergen;
        }


        public override string ToString()
        {
            var conclusion = string.Empty;
            if (!string.IsNullOrEmpty(Name))
                conclusion = $"{Name} Has No Allergies!";
            
            if (!string.IsNullOrEmpty(Name) && Score > 0)
                    conclusion = $"{Name} Is Allergic To {Utilities.GetAllergies(Score)}.";

            if (!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Description))
                conclusion = $"{Name} Is Allergic To {Utilities.OrderAllergies(Description)}.";

            return conclusion;
        }
    }
}