using System;

namespace rock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            bool playing = true;
            int gamesPlayed = 0;
            int gamesWon = 0;
            int gamesLost = 0;
            int gamesTied = 0;
            Random random = new Random();
            string[] computerArr  = new string[] {"r","p","s","r"};
            //string[] playerBeats  = new string[] {"(R)ock","(P)aper", "(S)cissors" };
            
            while (playing)
            {
                System.Console.WriteLine("Would you like to play a game? Y/N");
                string userInput = Console.ReadLine();
                playing = userInput.ToLower() == "y";
                if (playing)
                {
                    gamesPlayed++;
                    int computerChoice = random.Next(0, 3);

                    System.Console.WriteLine(computerChoice);
                    System.Console.WriteLine("(R)ock, (P)aper or (S)cissors -enter first character");
                    string choice  = Console.ReadLine();
                    if (choice.ToLower() != "r" & choice.ToLower() != "p" & choice.ToLower() != "s")
                    {
                        System.Console.WriteLine("invalid selection");
                        continue;
                    }
                    if ( choice.ToLower() == computerArr[computerChoice])
                    {
                        System.Console.WriteLine("tie");
                        gamesTied++;
                    } else 
                    if ( choice.ToLower() == computerArr[computerChoice + 1])
                    {
                      System.Console.WriteLine("You win");
                      gamesWon++;
                    }
                    else 
                    {
                        System.Console.WriteLine("You lose");  
                        gamesLost++; 
                    }
                }
            }
            System.Console.WriteLine("Thanks for playing!"); 
            System.Console.WriteLine($"You played {gamesPlayed} games {gamesWon} / {gamesLost} / {gamesTied}"); 

        }
    }
}
