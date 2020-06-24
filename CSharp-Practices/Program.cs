using System;

namespace CSharp_Practices
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exam1();
            // Exam2();
            // Exam3();
            // Exam4();
            // Exam5();
            // Console.ReadKey();

            ///
            var person = TupleSample2.GetNewTuple();
            Console.WriteLine($"Name : {person.Item1} Email : {person.Item2} Age : {person.Item3}");

            var Homoro = TupleSample2.GetPerson();
            Console.WriteLine($"{Homoro.name} - {Homoro.email} - {Homoro.age}");

            Console.ReadLine();

        }

        static void Exam1()
        {
            var person = new Tuple<string, string, int>("Homoro", "mr.Homoro@gmail.com", 26);
            Console.WriteLine($"Name : {person.Item1}, Email : {person.Item2}, Age : {person.Item3}.");
        }

        static void Exam2()
        {
            var info = Tuple.Create("mrhomoro.com", "mr.homoro@gmail.com", "Mr.Homoro", "0182378258", "1");
            Console.WriteLine($"{info.Item1} - {info.Item2} - {info.Item3} - {info.Item4} - {info.Item5}");
        }

        static void Exam3()
        {
            var nestedTuple = new Tuple<int, int, int, int, int, int, int,
            Tuple<string, string>>(1, 2, 3, 4, 5, 6, 7, Tuple.Create("Mr.", "Homoro"));
            Console.WriteLine("{0},{1},{2}", nestedTuple.Item3, nestedTuple.Rest.Item1, nestedTuple.Rest.Item2);
        }

        static void Exam4()
        {
            TupleSample1 ts = new TupleSample1();
            var person = Tuple.Create("Mr.", "Homoro", 26);
            ts.SetTupleInMethod(person);
        }

        static void Exam5()
        {
            var person = TupleSample1.GetTuple();
            Console.WriteLine($"Name : {person.Item1}, Email : {person.Item2}, Age: {person.Item3}.");
        }
    }

    public class TupleSample1
    {
        public void SetTupleInMethod(Tuple<string, string, int> person)
        {
            Console.WriteLine($"Name : {person.Item1}, Email : {person.Item2}, Age: {person.Item3}.");
        }

        public static Tuple<string, string, int> GetTuple()
        {
            return Tuple.Create("Mr.", "Homoro", 26);
        }
    }


    /// Note:
    /// using System.ValueTuple
    /// 

    class TupleSample2
    {
        public static (string, string, int) GetNewTuple()
        {
            string name = "Homoro";
            string email = "mr.Homoro@gmail.com";
            int age = 26;

            return (name, email, age);
        }

        public static (string name, string email, int age) GetPerson()
        {
            string name = "Homoro";
            string email = "mr.Homoro@gmail.com";
            int age = 26;

            return (name, email, age);
        }

    }
}