using System;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Vit");
            Person person2 = person;
            person2.Age = 25;

            // person.Name = "Vitalijs";
            person.Age = 25;
            person.Money = 205.88;
            person.Initial = "A";

            string greeting = person.GetGreeting();
            Console.WriteLine(greeting);
        }
    }
}
