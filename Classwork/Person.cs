using System;


namespace Classwork
{
    public class Person
    {
        public Person(string name) {
            Name = name; 
        }
        public string Name { get;  }
        private int _age;
        public int Age { 
            get { return _age; }
            set { _age = Math.Abs(value); }
        }
        public double Money { get; set; }
        public string IsMale { get; set; }
        public string Initial { get; set; }
        public string GetGreeting() 
        {
            string greeting = "Hello my name is " + Name + " and I am " +Age + " years old";
            return greeting;
        }
    }
}
