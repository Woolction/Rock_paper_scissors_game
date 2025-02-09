namespace Rock_paper_scissors_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            bool play = true;

            string Element = Convert.ToString(rnd.Next(1, 4));
            string Stone = "Stone", Scissors = "Scissors", Paper = "Paper";
            string sg = "";
            string k = "";

            while (play)
            {

                Console.Write("print Stone or Scissors or Paper: ");
                sg = Console.ReadLine();

                if (sg == "")
                {
                    while (true)
                    {
                        Console.Write("print Stone or Scissors or Paper: ");
                        sg = Console.ReadLine();

                    }
                }

                else { }

                switch (sg)
                {
                    case "stone":
                        sg = sg.Replace("s", "S");
                        break;
                    case "scissors":
                        sg = sg.Replace("s", "S");
                        break;
                    case "paper":
                        sg = sg.Replace("p", "P");
                        break;

                }

                if (Element == "1")
                {
                    Element = "Stone"; Console.WriteLine(); Console.WriteLine(Element);
                }
                else if (Element == "2")
                {
                    Element = "Scissor"; Console.WriteLine(); Console.WriteLine(Element);
                }
                else if (Element == "3")
                {
                    Element = "Paper"; Console.WriteLine(); Console.WriteLine(Element);
                }

                if (sg == Stone && Element == "Stone") { Console.WriteLine("draw"); }
                else if (sg == Stone && Element == "Scissor") { Console.WriteLine("you Win!"); }
                else if (sg == Stone && Element == "Paper") { Console.WriteLine("you Defeat"); }
                else if (sg == Scissors && Element == "Stone") { Console.WriteLine("you Defeat"); }
                else if (sg == Scissors && Element == "Scissor") { Console.WriteLine("draw"); }
                else if (sg == Scissors && Element == "Paper") { Console.WriteLine("you Win!"); }
                else if (sg == Paper && Element == "Stone") { Console.WriteLine("you Win!"); }
                else if (sg == Paper && Element == "Scissor") { Console.WriteLine("you Defeat"); }
                else if (sg == Paper && Element == "Paper") { Console.WriteLine("draw"); }

                else { Console.WriteLine("You gotta choose rock or paper or scissor!"); }

                Console.WriteLine("Do you want to play again? (Y/N): ");
                k = Console.ReadLine(); k = k.ToUpper();

                if (k == "Y") { play = true; }
                else { play = false; }
            }
        }
    }
}
