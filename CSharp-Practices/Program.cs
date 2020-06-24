using System;

namespace CSharp_Practices
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Homoro", "mr.homoro@gmail.com");
            //Console.WriteLine($"Name: {p.Name}, Email: {p.Email}");

            // using deconstruct:
            var (Name, email) = p;
            Console.WriteLine($"Name: {Name}, Email: {email}");
        }
    }

    class Person
    {
        public string Name { get; }
        public string Email { get; }

        public Person(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public void Deconstruct(out string name, out string email)
        {
            name = Name;
            email = Email;
        }


    }
}
