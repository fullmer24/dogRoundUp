
using System.Collections.Generic;
using dogRoundUp.Models;

namespace dogRoundUp.db
{
    public static class Db
    {
        public static List<Dog> Dogs { get; set; } = new List<Dog>(){
new Dog("Buddy", "lab", 10, "black", "M", true, 1)
        };
    }
}