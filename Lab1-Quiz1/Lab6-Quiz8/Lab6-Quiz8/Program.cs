using System;

class Animal
{
    public void DisplayAnimal()
    {
        Console.WriteLine("I am an animal.");
    }
}

class Dog : Animal
{
    public void DisplayDog()
    {
        Console.WriteLine("I have four legs.");
    }
}

class Program
{
    static void Main()
    {
        Animal animal = new Animal();
        Dog dog = new Dog();

        animal.DisplayAnimal();
        dog.DisplayDog();

        Console.WriteLine("I am an animal and " + "I have four legs.");
    }
}
