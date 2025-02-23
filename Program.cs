using System.Text;
using System.Xml.Linq;

namespace Rock_paper_scissors_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            bool play = true;
            bool Examination = false;
          
            Dictionary<string, string> Choise = new Dictionary<string, string>()
            {
                { "Stone", "Scissors" },
                { "Paper", "Stone" },
                { "Scissors", "Paper" }
            };
            
            string Systems = Convert.ToString(rnd.Next(1, 4));
            string Stone = "Stone", Scissors = "Scissors", Paper = "Paper";
            string Player;
            string IsPlaying;

            while (play)
            {

                Console.Write("print Stone or Scissors or Paper: ");
                Player = Console.ReadLine();

                switch (Player)
                {
                    case "stone":
                        Player = Player.Replace("s", "S"); break;
                    case "scissors":
                        Player = Player.Replace("s", "S"); break;
                    case "paper":
                        Player = Player.Replace("p", "P"); break;

                }

                if (Player == "" || Player != "Stone" || Player != "Scissors" || Player != "Paper")
                {
                    Examination = true;
                    
                    while (Examination)
                    {
                        Console.Write("print Stone or Scissors or Paper: ");
                        Player = Console.ReadLine();

                        switch (Player)
                        {
                            case "stone":
                                Player = Player.Replace("s", "S"); break;
                            case "scissors":
                                Player = Player.Replace("s", "S"); break;
                            case "paper":
                                Player = Player.Replace("p", "P"); break;

                        }

                        if (Player == "Stone" || Player == "Scissors" || Player == "Paper") 
                        {
                            Examination = false;
                        }
                        else { Examination = true; }
                    }
                }

                switch (Systems) 
                {
                    case "1":
                        Systems = "Stone"; Console.WriteLine(); Console.WriteLine("System: " + Systems); break;
                    case "2":
                        Systems = "Scissors"; Console.WriteLine(); Console.WriteLine("System: " + Systems); break;
                    case "3":
                        Systems = "Paper"; Console.WriteLine(); Console.WriteLine("System: " + Systems); break;
                }
               
                if (Player == Systems) 
                {
                    Console.WriteLine("draw"); 
                }
                else if (Choise[Player] == Systems) 
                {
                    Console.WriteLine("you Win!");
                }
                else 
                {   
                    Console.WriteLine("You gotta choose rock or paper or scissor!"); 
                }

                Console.WriteLine();
                Console.WriteLine("Do you want to play again? (Y/N): ");
                IsPlaying = Console.ReadLine(); IsPlaying = IsPlaying.ToUpper();

                if (IsPlaying == "Y") { play = true; }
                else { play = false; }
            }
        }
    }
}
