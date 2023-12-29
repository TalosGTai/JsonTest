using System;
using System.Runtime.CompilerServices;
using System.Text.Json;


namespace ConsoleApp2
{
    public class Company
    {
        public string Name { get; set; }
        public string DirectorName { get; set; }
        public int CountPeople { get; set; }
        public bool CompanyLogo { get; set; }

        public void About()
        {
            Console.WriteLine($"{Name} | {DirectorName} | {CountPeople} | {CompanyLogo}");
        }
    }

    public class CompanyEmpty
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CountPeople { get; set; }
        public bool CompanyLogo { get; set; }

        public void About()
        {
            Console.WriteLine($"{Name} | {Description} | {CountPeople} | {CompanyLogo}");
        }
    }

    public class CompanyError
    {
        public string Name { get; set; }
        public string DirectorName { get; set; }
        public string CountPeople { get; set; }
        public string CompanyLogo { get; set; }

        public void About()
        {
            Console.WriteLine($"{Name} | {DirectorName} | {CountPeople} | {CompanyLogo}");
        }
    }

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Attempts { get; set; }
        public int ProblemsSolved { get; set; }

        public void About()
        {
            Console.WriteLine($"{Name} | {Age} | {Attempts} | {ProblemsSolved}");
        }
    }

    public class UserJson
    {
        public User User { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Task1();
            //Task2();
            //Task3();
            //Task4();
        }

        static void Task1()
        {
            string path = "..\\..\\Company.json";
            string json = System.IO.File.ReadAllText(path);
            Company company = JsonSerializer.Deserialize<Company>(json);
            company.About();
            Console.ReadKey();
        }

        static void Task2()
        {
            string path = "..\\..\\Company.json";
            string json = System.IO.File.ReadAllText(path);
            CompanyEmpty company = JsonSerializer.Deserialize<CompanyEmpty>(json);
            company.About();
            Console.ReadKey();
        }

        static void Task3()
        {
            string path = "..\\..\\Company.json";
            string json = System.IO.File.ReadAllText(path);
            try
            {
                CompanyError company = JsonSerializer.Deserialize<CompanyError>(json);
                company.About();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ошибка из-за разного типа параметров");
            }
            Console.ReadKey();
        }
        
        static void Task4()
        {
            string path = "..\\..\\Test.json";
            string json = System.IO.File.ReadAllText(path);
            UserJson user = JsonSerializer.Deserialize<UserJson>(json);
            user.User.About();
            Console.ReadKey();
        }
    }
}
