using System;

namespace Individuellt_Projekt_Banksimulator
{
    class Program
    {
        static void WelcomePhrase()
        {
            string[] welcomePhrase = { "Vi tar hand om dina pengar", "Ge oss dina pengar", "Vi älskar dina pengar", "Mmmm, pengar", "Money, money, money", "Mer pengar tack!" };
            Random random = new Random();
            int index = random.Next(1, welcomePhrase.Length);

            Console.WriteLine("\t\t\"" + welcomePhrase[(index)] + "\"");
        }
        static void Main(string[] args)
        {
            List<string[]> users = new List<string[]> 
            { 
                new string[] {"Jack", },
            };
            Console.WriteLine("      $$\\      $$\\ $$$$$$$$\\  $$$$$$\\   $$$$$$\\             ");
            Console.WriteLine("      $$$\\    $$$ |$$  _____|$$  __$$\\ $$  __$$\\            ");
            Console.WriteLine("      $$$$\\  $$$$ |$$ |      $$ /  \\__|$$ /  $$ |           ");
            Console.WriteLine("      $$\\$$\\$$ $$ |$$$$$\\    $$ |$$$$\\ $$$$$$$$ |           ");
            Console.WriteLine("      $$ \\$$$  $$ |$$  __|   $$ |\\_$$ |$$  __$$ |           ");
            Console.WriteLine("      $$ |\\$  /$$ |$$ |      $$ |  $$ |$$ |  $$ |           ");
            Console.WriteLine("      $$ | \\_/ $$ |$$$$$$$$\\ \\$$$$$$  |$$ |  $$ |           ");
            Console.WriteLine("      \\__|     \\__|\\________| \\______/ \\__|  \\__|           ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("$$$$$$$\\   $$$$$$\\  $$\\   $$\\ $$\\   $$\\ $$$$$$$$\\ $$\\   $$\\ ");
            Console.WriteLine("$$  __$$\\ $$  __$$\\ $$$\\  $$ |$$ | $$  |$$  _____|$$$\\  $$ |");
            Console.WriteLine("$$ |  $$ |$$ /  $$ |$$$$\\ $$ |$$ |$$  / $$ |      $$$$\\ $$ |");
            Console.WriteLine("$$$$$$$\\ |$$$$$$$$ |$$ $$\\$$ |$$$$$  /  $$$$$\\    $$ $$\\$$ |");
            Console.WriteLine("$$  __$$\\ $$  __$$ |$$ \\$$$$ |$$  $$<   $$  __|   $$ \\$$$$ |");
            Console.WriteLine("$$ |  $$ |$$ |  $$ |$$ |\\$$$ |$$ |\\$$\\  $$ |      $$ |\\$$$ |");
            Console.WriteLine("$$$$$$$  |$$ |  $$ |$$ | \\$$ |$$ | \\$$\\ $$$$$$$$\\ $$ | \\$$ |");
            Console.WriteLine("\\_______/ \\__|  \\__|\\__|  \\__|\\__|  \\__|\\________|\\__|  \\__|");
            Console.WriteLine("");
            WelcomePhrase();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            Console.WriteLine("Vänligen logga in: ");
            Console.Write("Användarnamn: ");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("____MENY____ ");
            Console.WriteLine("1. Se dina konton och saldo");
            Console.WriteLine("2.Överföring mellan konton");
            Console.WriteLine("3.Ta ut pengar");
            Console.WriteLine("4.Logga ut");
            Console.Write("Val: ");
            string menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                default:
                    break;
            }

        }
    }
}
