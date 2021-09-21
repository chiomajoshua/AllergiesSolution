using System;
using System.Collections.Generic;
using System.Linq;
using static AllergiesSolution.Core.Enums;

namespace AllergiesSolution.Core
{
    public static class Utilities
    {
        private static readonly int[] ScoreList = ((Allergen[])Enum.GetValues(typeof(Allergen))).Select(c => (int)c).ToArray();
        public static IEnumerable<IEnumerable<T>> SubSetsOf<T>(this IEnumerable<T> source)
        {
            if (!source.Any())
                return Enumerable.Repeat(Enumerable.Empty<T>(), 1);

            return SubSetsOf(source.Skip(1)).Select(set => source.Take(1).Concat(set)).Concat(SubSetsOf(source.Skip(1)));
        }

        public static string GetAllergens(int score)
        {
            var allergens = string.Empty;


            foreach (var match in (from subset in ScoreList.SubSetsOf()
                                   where subset.Sum() == score
                                   select subset))
            {
                allergens = match.Select(m => m.ToString()).Aggregate((a, n) => a + "," + n).ToString();
            }

            return allergens.Trim();
        }

        public static bool IsAllergicTo(string allergen)
        {
            return ((Allergen[])Enum.GetValues(typeof(Allergen)))
                                    .Select(c => c.ToString())
                                    .ToList()
                                    .ConvertAll(d => d.ToLower())
                                    .Any(x => x.Contains(allergen.ToLower()));
        }        

        public static bool IsAllergicTo(Allergen allergen)
        {
            return Enum.IsDefined(typeof(Allergen), allergen);
        }

        public static string GetAllergies(int score)
        {
            var result = new List<string>();

            var allergens = GetAllergens(score);
            foreach (var item in allergens.Split(','))
            {
                result.Add(((Allergen)Convert.ToInt32(item)).ToString());
            }

            //Convert to comma seperated string
            string allergies = string.Join(", ", result);
            int index = allergies.LastIndexOf(",");

            return allergies.Remove(index, 1).Insert(index, ", and ");
        }

        public static string OrderAllergies(string allergies)
        {
            int score = 0;
            foreach(var allergy in allergies.Split(' '))
            {
                if (IsAllergicTo(allergy))
                {
                    score += (int)Enum.Parse(typeof(Allergen), allergy);
                }
            }

            return GetAllergies(score);
        }
    }
}