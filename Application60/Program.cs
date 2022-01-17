using System;

namespace Application60
{
    class Program
    {
        static void Main(string[] args)
        {
            InvitationApp();
            string userName = InputUser();
            WelcomeUser(userName);

            Random random = new Random();
            int correctNumber = random.Next(1, 11);
            //int correctNumber = 7;

            bool correctAnswer = false;
            Console.WriteLine("Zganij liczbę z zakresu od 1 do 10");
            //int guess = NumberInput();

            while (!correctAnswer)
            {
                string input = Console.ReadLine();
                int guess;
                bool isNumber = int.TryParse(input, out guess);

                if (!isNumber)
                {
                    Console.WriteLine("Prosze podaj liczbę");
                    continue;
                }

                else if(guess<1 || guess>10)
                {
                    Console.WriteLine("Wprowadź liczbę z zakresu od 1 do 10!");
                    continue;
                }
                else if (guess<correctNumber)
                {
                    Console.WriteLine("Podana liczba jest zbyt niska");
                    continue;
                }
                else if(guess>correctNumber)
                {
                    Console.WriteLine("Podana liczna jest zbyt wysoka");
                    continue;
                }
                else
                {
                    correctAnswer = true;
                    Console.WriteLine("Brawo, zgadłeś!");
                    break;
                }

            }

            Console.ReadKey();
        }
        static void InvitationApp()
        {
            string appName = "NumberGuesser";
            string appAuthor = "Konrad Kruczkowski";
            string appVersion = "1.0.0";
            Console.WriteLine($"Witaj w aplikacji {appName} w wersji {appVersion}, której autorem jest {appAuthor}");
            Console.WriteLine();
        }

        static string InputUser()
        {
            Console.WriteLine("Jak masz na imie");
            string userName = Console.ReadLine();
            return userName;
      
        }

        static void WelcomeUser(string userName)
        { 
            Console.WriteLine($"Witaj {userName}");
           
        }

        static int NumberInput()
        {
            
            
            int guessNumber = Convert.ToInt32(Console.ReadLine());
            return guessNumber;
        }
    }
}

