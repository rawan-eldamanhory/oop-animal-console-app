using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public interface IAnimal
    {
        void Eat();
        void Sleep();
        void Walk();
    }

    public abstract class Animal : IAnimal
    {
        private string name;
        private int age;
        public int weight;
        public void SetName(string N)
        {
            this.name = N;
        }
        public string GetName()
        {
            return this.name ;
        }
        public void SetAge(int A)
        {
            this.age = A;
        }
        public int GetAge()
        {
            return this.age;
        }
        public abstract void Eat();
        public abstract void Sleep();
        public abstract void Walk();
    } 

    public class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("The Cat is Eating.");
        }
        public override void Sleep()
        {
            Console.WriteLine("The Cat is Sleeping.");
        }
        public override void Walk()
        {
            Console.WriteLine("The Cat is Walking.");
        }
        public void Meaw()
        {
            Console.WriteLine("Meaw Meaw");
        }
    }
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("The Dog is Eating.");
        }
        public override void Sleep()
        {
            Console.WriteLine("The Dog is Sleeping.");
        }
        public override void Walk()
        {
            Console.WriteLine("The Dog is Walking.");
        }
        public void Bark()
        {
            Console.WriteLine("how how");
        }
    }
        public class Cow : Animal
        {
            public override void Eat()
            {
                Console.WriteLine("The Cow is Eating.");
            }
            public override void Sleep()
            {
                Console.WriteLine("The Cow is Sleeping.");
            }
            public override void Walk()
            {
                Console.WriteLine("The Cow is Walking.");
            }
            public void ProduceMilk()
            {
                Console.WriteLine("We get milk from Cow");
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            c.SetName("Cat");
            Console.WriteLine(c.GetName());
            c.SetAge(5);
            Console.WriteLine(c.GetAge());
            c.weight = 15;
            c.Eat();
            c.Sleep();
            c.Walk();
            c.Meaw();

            Dog d = new Dog();
            d.SetName("Dog");
            Console.WriteLine(d.GetName());
            d.SetAge(7);
            Console.WriteLine(d.GetAge());
            d.weight = 20;
            d.Eat();
            d.Sleep();
            d.Walk();
            d.Bark();

            Cow w = new Cow();
            w.SetName("Cow");
            Console.WriteLine(w.GetName());
            w.SetAge(8);
            Console.WriteLine(w.GetAge());
            w.weight = 30;
            w.Eat();
            w.Sleep();
            w.Walk();
            w.ProduceMilk();

            Animal animal = new Cat();
            animal.Eat();
            animal.Sleep();
            animal.Walk();
        }
    }
}
