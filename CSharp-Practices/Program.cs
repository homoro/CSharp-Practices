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
            Exam5();
            Console.ReadKey();
        }

        static void Exam1()
        {
            var person = new Tuple<string, string, int>("Mr.", "Homoro", 26);
            Console.WriteLine($"Name : {person.Item1} Family : {person.Item2} Age : {person.Item3}");
        }

        static void Exam2()
        {
            var site = Tuple.Create("mrhomoro.com", "mr.homoro@gmail.com", "Mr.Homoro", "0182378258", "1");
            Console.WriteLine($"{site.Item1} - {site.Item2} - {site.Item3} - {site.Item4} - {site.Item5}");
        }

        static void Exam3()
        {
            var nestedTuple = new Tuple<int, int, int, int, int, int, int,
            Tuple<string, string>>(1, 2, 3, 4, 5, 6, 7, Tuple.Create("Mr.", "Homoro"));
            Console.WriteLine("{0},{1},{2}", nestedTuple.Item3, nestedTuple.Rest.Item1, nestedTuple.Rest.Item2);
        }

        static void Exam4()
        {
            TupleSample ts = new TupleSample();
            var person = Tuple.Create("Mr.", "Homoro", 26);
            ts.SetTupleInMethod(person);
        }

        static void Exam5()
        {
            var person = TupleSample.GetTuple();
            Console.WriteLine($"Name : {person.Item1} Family : {person.Item2} Age: {person.Item3}");
        }
    }

    public class TupleSample
    {
        public void SetTupleInMethod(Tuple<string, string, int> person)
        {
            Console.WriteLine($"Name : {person.Item1} Family : {person.Item2} Age: {person.Item3}");
        }

        public static Tuple<string, string, int> GetTuple()
        {
            return Tuple.Create("Mr.", "Homoro", 26);
        }

    }
}