using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Part2
{
    public class Cat : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Height { get; set; }
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("Cats eat mice");
        }

        public string Cry()
        {
            return "Meow!";
        }
    }
}
