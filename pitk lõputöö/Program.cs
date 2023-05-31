using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pitk_lõputöö
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SkipLINQ();
            AllLINQ();
            Fail();
            Püramiid();
        }
        public static void SkipLINQ()
        {
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("----------Skip--------------");

            var skip = PeopleList.peoples.Skip(3);

            foreach (var item in skip)
            {
                Console.WriteLine(item.Name);
            }
        }
        public static void AllLINQ()
        {
            Console.WriteLine("All LINQ");

            bool areAllPeopleTeenagers = PeopleList.peoples.All(x => x.Age > 18);

            Console.WriteLine(areAllPeopleTeenagers);
        }
        static void Fail()
        {
            Console.WriteLine("Kirjuta faili läbi konsooli");

            string filePath = @"C:\Users\opilane\Documents\w\uus.txt";
            string inputText = Console.ReadLine();

            File.WriteAllText(filePath, inputText);
        }
        static void Püramiid()
        {
            int i, j, rows;

            Console.WriteLine("Numbri püramiid");

            Console.WriteLine("Sisesta ridade arv");

            rows = Convert.ToInt32(Console.ReadLine());


            for (i = 0; i <= rows; i++)
            {
                for (j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*"); 
                }
                Console.Write("\n");
            }

            for (i = rows - 1; i >= 1; i--)
            {
                for (j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
        public class PeopleList
        {
            public static readonly List<People> peoples = new List<People>
        {
            new People()
            {
                Id = 1,
                Name = "Moona",
                Age = 31,
                GenderId = Guid.Parse("4c4209e5-7a1b-429d-91ed-bbe20844f29e")
            },
            new People()
            {
                Id = 2,
                Name = "Poona",
                Age = 21,
                GenderId = Guid.Parse("81985602-b844-4bec-9066-7059f7169913")
            },
            new People()
            {
                Id = 3,
                Name = "Ron",
                Age = 18,
                GenderId = Guid.Parse("81985602-b844-4bec-9066-7059f7169913")
            },
            new People()
            {
                Id = 4,
                Name = "Anna",
                Age = 20,
                GenderId = Guid.Parse("4c4209e5-7a1b-429d-91ed-bbe20844f29e")
            },
            new People()
            {
                Id = 5,
                Name = "Mari",
                Age = 16,
                GenderId = Guid.Parse("4c4209e5-7a1b-429d-91ed-bbe20844f29e")
            },
            new People()
            {
                Id = 6,
                Name = "Mare",
                Age = 11,
                GenderId = Guid.Parse("4c4209e5-7a1b-429d-91ed-bbe20844f29e")
            },
            new People()
            {
                Id = 7,
                Name = "Bill",
                Age = 22,
                GenderId = Guid.Parse("81985602-b844-4bec-9066-7059f7169913")
            }
        };
        }
    }
}

