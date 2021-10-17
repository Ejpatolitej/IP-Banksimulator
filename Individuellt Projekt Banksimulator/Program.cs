using System;
using System.Collections.Generic;
using System.Threading;

namespace Individuellt_Projekt_Banksimulator
{
    class Program
    {
        //Method for printing out info about the account
        static void AccountSummary(string userLogin, string pin, string[] userArray)
        {
            Console.WriteLine("Användarnamn: " + userLogin);
            Console.WriteLine("Användarpin: " + pin);
            //Wanted a number in front of every account for readability, so added "count" as an int
            int count = 1;
            for (int j = 2; j < userArray.Length; j = j + 2)
            {
                Console.WriteLine(count++ + ". " + userArray[j] + ": " + userArray[j + 1]);
            }
        }
        //Method for transfering money between two accounts
        static void AccountTransfer(string[] userArray)
        {
            Console.WriteLine("Välj ett konto att flytta från");
            //Wanted a number in front of every account for readability, so added "count" as an int
            int count = 1;
            for (int j = 2; j < userArray.Length; j = j + 2)
            {
                Console.WriteLine(count++ + ". " + userArray[j] + ": " + userArray[j + 1]);
            }
            //Parse user input to int to use in array
            int transferFrom = Int32.Parse(Console.ReadLine());
            //Parse amount from string to double to use with math
            double balanceFrom = Double.Parse(userArray[transferFrom * 2 + 1]);
            Console.Clear();
            Console.WriteLine("Välj ett konto att flytta till");
            count = 1;
            for (int j = 2; j < userArray.Length; j = j + 2)
            {
                Console.WriteLine(count++ + ". " + userArray[j] + ": " + userArray[j + 1]);
            }
            int transferTo = Int32.Parse(Console.ReadLine());
            double balanceTo = Double.Parse(userArray[transferTo * 2 + 1]);
            double transferAmount = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Välj belopp att flytta");
                transferAmount = Double.Parse(Console.ReadLine());
                //Checks transfer amount is not less than zero or more than the account
                if (transferAmount > balanceFrom || transferAmount < 0)
                {
                    Console.WriteLine("Inte tillräckligt med saldo på kontot. Försök igen!");
                    Console.ReadKey();
                }
            } while (transferAmount > balanceFrom || transferAmount < 0);
            balanceFrom -= transferAmount;
            balanceTo += transferAmount;
            //Transform amount back to string and put it back into the array
            userArray[transferTo * 2 + 1] = balanceTo.ToString();
            userArray[transferFrom * 2 + 1] = balanceFrom.ToString();
        }
        //Method for withdrawing money from account
        static void AccountWithdraw(string[] userArray, string pin)
        {
            Console.WriteLine("Välj ett konto att ta ut pengar från");
            //Wanted a number in front of every account for readability, so added "count" as an int
            int count = 1;
            for (int j = 2; j < userArray.Length; j = j + 2)
            {
                Console.WriteLine(count++ + ". " + userArray[j] + ": " + userArray[j + 1]);
            }
            //Parse user input to int to use in array
            int withdraw = Int32.Parse(Console.ReadLine());
            //Parse amount from string to double to use with math
            double accountBalance = Double.Parse(userArray[withdraw * 2 + 1]);
            double withdrawAmount = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Välj belopp att ta ut");
                withdrawAmount = Double.Parse(Console.ReadLine());
                //Checks withdraw amount is not less than zero or more than the account
                if (withdrawAmount > accountBalance || withdrawAmount < 0)
                {
                    Console.WriteLine("Inte tillräckligt med saldo på kontot. Försök igen!");
                    Console.ReadKey();
                }
            } while (withdrawAmount > accountBalance || withdrawAmount < 0);
            string checkPin;
            //Checks the user pin for security
            do
            {
                Console.Clear();
                Console.Write("Skriv in din pin: ");
                checkPin = Console.ReadLine();
                if (checkPin != pin)
                {
                    Console.WriteLine("Fel pin, försök igen!");
                    Console.ReadKey();
                }
            } while (checkPin != pin);
            accountBalance -= withdrawAmount;
            //Transform amount back to string and put it back into the array
            userArray[withdraw * 2 + 1] = accountBalance.ToString();
            Console.WriteLine("Nytt saldo: " + accountBalance);
        }
        //Method for deposit money to account
        static void AccountDeposit(string[] userArray, string pin)
        {
            string checkPin;
            //Checks the user pin for security
            do
            {
                Console.Clear();
                Console.Write("Skriv in din pin: ");
                checkPin = Console.ReadLine();
                if (checkPin != pin)
                {
                    Console.WriteLine("Fel pin, försök igen!");
                    Console.ReadKey();
                }
            } while (checkPin != pin);
            Console.WriteLine("Välj ett konto att sätta in pengar på");
            //Wanted a number in front of every account for readability, so added "count" as an int
            int count = 1;
            for (int j = 2; j < userArray.Length; j = j + 2)
            {
                Console.WriteLine(count++ + ". " + userArray[j] + ": " + userArray[j + 1]);
            }
            //Parse user input to int to use in array
            int deposit = Int32.Parse(Console.ReadLine());
            //Parse amount from string to double to use with math
            double accountBalance = Double.Parse(userArray[deposit * 2 + 1]);
            double depositAmount = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Välj belopp att sätta in");
                depositAmount = Double.Parse(Console.ReadLine());
                //Checks deposit amount is not less than zero
                if (depositAmount < 0)
                {
                    Console.WriteLine("Kan inte sätta in mindre än 0. Försök igen!");
                    Console.ReadKey();
                }
            } while (depositAmount < 0);
            accountBalance += depositAmount;
            //Transform amount back to string and put it back into the array
            userArray[deposit * 2 + 1] = accountBalance.ToString();
            Console.WriteLine("Nytt saldo: " + accountBalance);
        }
        //Method for printing a random welcome message to the user
        static void WelcomePhrase()
        {
            //Array of strings as messages
            string[] welcomePhrase = { "Vi tar hand om dina pengar", "Ge oss dina pengar", "Vi älskar dina pengar", "Mmmm, pengar", "Money, money, money", "Mer pengar tack!" };
            Random random = new Random();
            int index = random.Next(1, welcomePhrase.Length);

            Console.WriteLine("\t\t\"" + welcomePhrase[(index)] + "\"");
        }
        static void Main(string[] args)
        {
            //A list of users, pins, accounts, and amount of those accounts
            List<string[]> users = new List<string[]>
            {
                new string[] {"Jack", "1337", "Sparkonto", "5,00", "Matkonto", "50000,00"},
                new string[] {"Emile", "6969", "Sparkonto", "20000,00", "ICE", "17500,00", "Nöje", "100000,00", "McDonalds", "500,00"},
                new string[] {"Jonathan", "1234", "Sparkonto", "-35000,25", "Fakturor", "0,00", "Matkonto", "3000,00"},
                new string[] {"Emma", "7946", "Sparkonto", "1000000,00", "Annat", "75000,00"},
                new string[] {"Alice", "1996", "Sparkonto", "32495,30", "Hästen", "8300,00", "ICE", "15342,00", "Tomt", "0,00"}
            };

            //A loop for the user login
            bool checkLogin = true;
            while (checkLogin == true)
            {
                //Welcome message for the login
                Console.Clear();
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
                Console.WriteLine("Vänligen logga in: ");
                Console.Write("Användarnamn: ");
                //Uses userLogin to search for the username
                string userLogin = Console.ReadLine();
                bool foundUser = false;
                //Searches the list of accounts for a username
                foreach (string[] userArray in users)
                {
                    //Checks the first string in the arrays of the list against the searchword
                    if (userArray[0] == userLogin)
                    {
                        //If the user is found, turns off loops
                        foundUser = true;
                        checkLogin = false;
                        bool checkPin = false;
                        //The user inputs the pin, if the pin is wrong 3 times it terminates the program
                        for (int i = 0; i < 3 && checkPin == false; i++)
                        {
                            //Console.Clear();
                            Console.Write("Skriv in din pinkod: ");
                            string pin = Console.ReadLine();
                            //Checks the second string in the user array against the pin entered
                            if (userArray[1] == pin)
                            {
                                checkPin = true;
                                bool runMenu = true;
                                while (runMenu == true)
                                {
                                    //Main menu of the account
                                    Console.Clear();
                                    Console.WriteLine("____MENY____ ");
                                    Console.WriteLine("1. Se dina konton och saldo");
                                    Console.WriteLine("2. Överföring mellan konton");
                                    Console.WriteLine("3. Ta ut pengar");
                                    Console.WriteLine("4. Sätt in pengar");
                                    Console.WriteLine("5. Logga ut");
                                    Console.Write("Val: ");
                                    string menuChoice = Console.ReadLine();

                                    switch (menuChoice)
                                    {
                                        //Prints the account name, pin, and accounts with amount
                                        case "1":
                                            Console.Clear();
                                            AccountSummary(userLogin, pin, userArray);
                                            Console.WriteLine("\nKlicka på Enter för att komma tillbaka till menyn.");
                                            Console.ReadKey();
                                            break;

                                        //Lets the user transfer between two accounts
                                        case "2":
                                            Console.Clear();
                                            AccountTransfer(userArray);
                                            Console.WriteLine("\nKlicka på Enter för att komma tillbaka till menyn.");
                                            Console.ReadKey();
                                            break;

                                        //Lets user withdraw money from a chosen account
                                        case "3":
                                            Console.Clear();
                                            AccountWithdraw(userArray, pin);
                                            Console.WriteLine("\nKlicka på Enter för att komma tillbaka till menyn.");
                                            Console.ReadKey();
                                            break;

                                        //Lets user depoist money to account
                                        case "4":
                                            Console.Clear();
                                            AccountDeposit(userArray, pin);
                                            Console.WriteLine("\nKlicka på Enter för att komma tillbaka till menyn.");
                                            Console.ReadKey();
                                            break;

                                        //Logs out the user
                                        case "5":
                                            Console.Clear();
                                            Console.WriteLine("Loggar ut, tack för idag! och kom ihåg: ");
                                            Console.WriteLine();
                                            WelcomePhrase();
                                            Console.WriteLine();
                                            runMenu = false;
                                            checkLogin = true;
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;

                                        default:
                                            Console.WriteLine("Ogiltigt val, försök igen!");
                                            break;
                                    }
                                }
                            }
                            //Message if the pin is wrong
                            else if (userArray[1] != pin)
                            {
                                Console.WriteLine("Fel pin. Du har " + (3 - i) + " försök kvar.");
                            }
                        }
                        //Message if the pin has been wrong too many times
                        if (checkPin == false)
                        {
                            Console.Clear();
                            Console.WriteLine("Du har skrivit fel pin för många gånger. Programmet är nu låst i 3 minuter.");
                            checkLogin = true;
                            Console.ReadKey();
                            //Program waits for 3 minutes
                            Thread.Sleep(180000);
                        }
                    }
                }
                //Message if the user isn't found in the list
                if (!foundUser)
                {
                    Console.Clear();
                    Console.WriteLine("Hittar inte användaren. Försök igen!");
                    Console.ReadKey();
                }
            }
        }
    }
}
