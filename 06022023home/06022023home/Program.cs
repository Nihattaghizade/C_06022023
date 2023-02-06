using System;
using System.Xml.Linq;

namespace _06022023home
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] students = { "Murad Ibrahimov", "Araz Huseynov", "Ayxan Ezimli", "Elgun Ceferli" };
            string opt;
            do
            {
                Console.WriteLine("\n1. Butub telebelere bax");
                Console.WriteLine("2. Yeni telebeler elave");
                Console.WriteLine("3. Telebelere uzre axtaris et");
                Console.WriteLine("4. Telebelerin adlarina bax");
                Console.WriteLine("5. Siyahida adin olub olmadigina bax");
                Console.WriteLine("0. Menudan cix");

                Console.WriteLine("\nSecim edin:");
                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        for (int i = 0; i < students.Length; i++)
                        {
                            Console.WriteLine(students[i]);
                        }
                        break;
                    case "2":
                        Console.WriteLine("Elave temek istediyiniz telebeni daxil edin:");
                        string std = Console.ReadLine();
                        Array.Resize(ref students, students.Length + 1);
                        students[students.Length - 1] = std;

                        break;
                    case "3":
                        Console.WriteLine("Telebeleri uzre axtaris et");
                        break;
                    case "4":
                        Console.WriteLine("Telebelerin adlarina bax");
                        break;
                    case "5":
                        Console.WriteLine("Siyahida adin olub olmadigina bax");
                        break;
                    case "0":
                        Console.WriteLine("Proses bitdi");
                        break;
                    default:
                        Console.WriteLine("Seciminiz yanlisdir, yeniden cehd edin!");
                        break;
                }


            } while (opt == "0");

        }
    }
}
