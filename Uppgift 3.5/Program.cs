using System;
namespace Uppgift_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in två tal");
            string siffror = Console.ReadLine();
            int mellansslagsindex = siffror.IndexOf(" ");
            string tal1text = siffror [..mellansslagsindex];
            string tal2text = siffror [(mellansslagsindex + 1)..];
            int tal1 = int.Parse(tal1text);
            int tal2 = int.Parse(tal2text);

            Console.WriteLine("Välj ett räknesätt.");
            Console.WriteLine("1. addition");
            Console.WriteLine("2. subtraktion");
            Console.WriteLine("3. multiplikation");
            Console.WriteLine("4. division");
            string räknesätt = Console.ReadLine();

            switch (räknesätt)
            {
                case "1":
                    {
                        Console.WriteLine("Dina tal adderade blir " + (tal1 + tal2));
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Dina tal subtraherade blir " + (tal1 - tal2));
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Dina tal multiplicerade blir " + (tal1 * tal2));
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("Dina tal dividerade blir " + (tal1 / tal2));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Du valde ingen av allternativen");
                        break;
                    }
             Console.ReadKey();
            }
        }
    }
}
