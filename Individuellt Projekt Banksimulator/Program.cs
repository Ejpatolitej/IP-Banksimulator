using System;
using System.Collections.Generic;

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
        static void AccountLayout(int userArray, string name, string pin, string acc1, string acc1Val, string acc2, string acc2Val)
        {
            Console.WriteLine("Användarnamn: " + name);
            Console.WriteLine("Användarpin: " + pin);
            for (int i = 2; i < userArray; i++)
            {
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            //En lista på användare, pin, konto, och värden på konton
            List<string[]> users = new List<string[]>
            {
                new string[] {"Jack", "1337", "Sparkonto", "5.00", "Matkonto", "50000.00"},
                new string[] {"Emile", "6969", "Sparkonto", "20000.00", "ICE", "17500.00", "Nöje", "100000.00", "McDonalds", "500.00"},
                new string[] {"Jonathan", "1234", "Sparkonto", "-35000.25", "Fakturor", "0.00", "Matkonto", "3000.00"},
                new string[] {"Emma", "7946", "Sparkonto", "1000000.00", "Annat", "75000.00"},
                new string[] {"Alice", "1996", "Sparkonto", "32495.30", "Hästen", "8300.00", "ICE", "15342.00", "Tomt", "0.00"}
            };

            Console.WriteLine("                    Välkommen till");
            Console.WriteLine(" ");
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
            bool checkLogin = true;
            while (checkLogin == true)
            {
                Console.WriteLine("Vänligen logga in: ");
                Console.Write("Användarnamn: ");
                string userLogin = Console.ReadLine();
                foreach (string[] userArray in users)
                {
                    if (userArray[0] == userLogin)
                    {
                        checkLogin = false;
                        bool checkPin = false;
                        for (int i = 0; i < 4; i++)
                        {
                            Console.Write("Skriv in din pinkod: ");
                            string pin = Console.ReadLine();
                            if (userArray[1] == pin)
                            {
                                checkPin = true;
                                bool runMenu = true;
                                while (runMenu == true)
                                {
                                    Console.Clear();
                                    Console.WriteLine("____MENY____ ");
                                    Console.WriteLine("1. Se dina konton och saldo");
                                    Console.WriteLine("2.Överföring mellan konton");
                                    Console.WriteLine("3.Ta ut pengar");
                                    Console.WriteLine("4.Logga ut och stäng av");
                                    Console.Write("Val: ");
                                    string menuChoice = Console.ReadLine();

                                    switch (menuChoice)
                                    {
                                        case "1":
                                            //AccountLayout(userArray.Length, userArray[0], userArray[1], userArray[3], userArray[4], userArray[5], userArray[6], userArray[7]);

                                            Console.WriteLine("Användarnamn: " + userLogin);
                                            Console.WriteLine("Användarpin: " + pin);
                                            for (int j = 2; j < userArray.Length; j++)
                                            {
                                                Console.WriteLine(userArray[j]);
                                            }
                                            Console.ReadKey();
                                            break;
                                        case "2":
                                            Console.WriteLine("Välj ett konto att flytta från");
                                            for (int j = 2; j < userArray.Length; j++)
                                            {
                                                Console.WriteLine(userArray[j]);
                                            }
                                            string transferFrom = Console.ReadLine();

                                            break;
                                        case "3":
                                            break;
                                        case "4":
                                            Console.Clear();
                                            Console.WriteLine("Loggar ut, tack för idag! och kom ihåg: ");
                                            Console.WriteLine();
                                            WelcomePhrase();
                                            Console.WriteLine();
                                            Environment.Exit(0);
                                            break;
                                        default:
                                            break;
                                    }
                                }
                            }
                            else if (userArray[1] != pin)
                            {
                                Console.WriteLine("Fel pin. Du har " + (3 - i) + " försök kvar.");
                            }
                        }
                        if (checkPin == false)
                        {
                            Console.Clear();
                            Console.WriteLine("Du har skrivit fel pin för många gånger. Programmet avslutas.");
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Hittar inte användare, försök igen!");
                        break;
                    }

                }
            }

        }
    }
}
