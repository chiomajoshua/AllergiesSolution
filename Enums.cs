using System.Runtime.Serialization;

namespace AllergiesSolution
{
    public class Enums
    {
        public enum Allergen
        {
            [EnumMember(Value = "eggs")]
            Eggs = 1,
            [EnumMember(Value = "peanuts")]
            Peanuts = 2,
            [EnumMember(Value = "shellfish")]
            Shellfish = 4,
            [EnumMember(Value = "strawberries")]
            Strawberries = 8,
            [EnumMember(Value = "tomatoes")]
            Tomatoes = 16,
            [EnumMember(Value = "chocolate")]
            Chocolate = 32,
            [EnumMember(Value = "pollen")]
            Pollen = 64,
            [EnumMember(Value = "cats")]
            Cats = 128
        }
    }
}