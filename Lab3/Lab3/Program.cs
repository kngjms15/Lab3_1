using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {

        //Lab 3_2: Interfaces and Abstract Classes
        //James Bareng - 000499449

        static void Main(string[] args)
        {
            //Dog portion
            Console.WriteLine("Enter a dog name: ");
            string name = Console.ReadLine();

            Dog dawg = new Dog();
            dawg.Name = name;

            Console.WriteLine("Enter the dog's colour: ");
            string dogColor = Console.ReadLine();
            dawg.Colour = dogColor;

            Console.WriteLine("Enter the dog's age: ");
            int dogAge = int.Parse(Console.ReadLine());
            dawg.Age = dogAge;

            Console.WriteLine($"Name: {dawg.Name}, Color: {dawg.Colour}, Age: {dawg.Age}");
            dawg.Eat();
            Console.ReadKey();


            // Cat portion
            Console.WriteLine("Enter a cat's name: ");
            string catName = Console.ReadLine();

            Cat kitty = new Cat();
            kitty.Name = name;

            Console.WriteLine("Enter the cat's colour: ");
            string kittyCol = Console.ReadLine();
            kitty.Colour = kittyCol;

            Console.WriteLine("Enter the cat's age: ");
            int kittyAge = int.Parse(Console.ReadLine());
            kitty.Age = dogAge;

            Console.WriteLine($"Name: {kitty.Name}, Color: {kitty.Colour}, Age: {kitty.Age}");
            kitty.Eat();
            Console.ReadKey();
        }
    }
}
