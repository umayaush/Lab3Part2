namespace Lab3Part2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dog's name: ");
            string dogName = Console.ReadLine();
            Console.WriteLine("\nEnter the dog's colour:");
            string dogColour = Console.ReadLine();
            Console.WriteLine("\nEnter the dog's height (cm):");
            int dogHeight = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter the dog's age:");
            int dogAge = int.Parse(Console.ReadLine());

            Dog dog = new Dog();
            dog.Name = dogName;
            dog.Colour = dogColour;
            dog.Height = dogHeight;
            dog.Age = dogAge;

            Console.WriteLine($"\nDog's Name: {dog.Name}\nDog's Colour: {dog.Colour}\nDog's Height: {dog.Height} cm\nDog's Age: {dog.Age}");
            dog.Eat();
            Console.WriteLine(dog.Cry());

            Console.WriteLine("\nEnter the cat's name:");
            string catName = Console.ReadLine();
            Console.WriteLine("\nEnter the cat's colour:");
            string catColour = Console.ReadLine();
            Console.WriteLine("\nEnter the cat's height (cm):");
            int catHeight = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter the cat's age:");
            int catAge = int.Parse(Console.ReadLine());

            Cat cat = new Cat();
            cat.Name = catName;
            cat.Colour = catColour;
            cat.Height = catHeight;
            cat.Age = catAge;

            Console.WriteLine($"\nCat's Name: {cat.Name}\nCat's Colour: {cat.Colour}\nCat's Height: {cat.Height} cm\nCat's Age: {cat.Age}");
            cat.Eat();
            Console.WriteLine(cat.Cry());

            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(dog);
            animals.Add(cat);

            Console.WriteLine("\nAnimal Names:");

            foreach (IAnimal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }

        }
    }
}
