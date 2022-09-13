

using System.ComponentModel.DataAnnotations;

namespace dogRoundUp.Models
{
    public class Dog
    {
        [Required]
        [MaxLength(15)]
        [MinLength(1)]
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public string Gender { get; set; }
        public bool IsTrained { get; set; }
        public int Id { get; set; }

        public Dog(string name, string breed, int age, string color, string gender, bool isTrained, int id)
        {
            Name = name;
            Breed = breed;
            Age = age;
            Color = color;
            Gender = gender;
            IsTrained = isTrained;
            Id = id;
        }
        public Dog()
        {

        }
    }



}