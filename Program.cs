// See https://aka.ms/new-console-template for more information
internal class Program
{
  static int PlayerWins = 0;
  static int ComputerWins = 0;

  static int Rounds = 3;


  public static void Main()
  {
    Console.Clear();
    CheckWinner();
    Console.WriteLine("Rock, Paper, Scissors!");
    string userHand = ChooseHand();
    string computerHand = GetComputerHand();
    Console.Clear();
    Console.WriteLine($"You Chose {userHand}");
    Console.WriteLine($"Opponent Chose {computerHand}");
    Thread.Sleep(1000);


    if (userHand == computerHand)
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine($"you Tied, Current Score you:{PlayerWins} - Opponent:{ComputerWins}");
      Console.ResetColor();
      PlayAgain();
    }
    else if (userHand == "rock" && computerHand == "scissors")
    {
      PlayerWins++;
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine($"you Win, Current Score you:{PlayerWins} - Opponent:{ComputerWins}");
      Console.ResetColor();
      PlayAgain();
    }
    else if (userHand == "paper" && computerHand == "rock")
    {
      PlayerWins++;
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine($"you Win, Current Score you:{PlayerWins} - Opponent:{ComputerWins}");
      Console.ResetColor();
      PlayAgain();
    }
    else if (userHand == "scissors" && computerHand == "paper")
    {
      PlayerWins++;
      Console.Clear();

      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine($"you Win, Current Score you:{PlayerWins} - Opponent:{ComputerWins}");
      Console.ResetColor();
      PlayAgain();
    }
    else
    {
      ComputerWins++;
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine($"you Lose, Current Score you:{PlayerWins} - Opponent:{ComputerWins}");
      Console.ResetColor();
      PlayAgain();
    }


  }
  public static void CheckWinner()
  {
    if (PlayerWins == Rounds)
    {
      Console.Clear();

      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine($"you Win, Final Score you:{PlayerWins} - Opponent:{ComputerWins}");
      Console.ResetColor();
      PlayerWins = 0;
      ComputerWins = 0;
      PlayAgain();
    }
    else if (ComputerWins == Rounds)
    {
      Console.Clear();

      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine($"you Lose, Final Score you:{PlayerWins} - Opponent:{ComputerWins}");
      Console.ResetColor();
      PlayerWins = 0;
      ComputerWins = 0;
      PlayAgain();
    }
  }

  public static string ChooseHand()
  {
    Console.Clear();
    Console.WriteLine("Choose A Hand");
    Console.WriteLine("1. Rock");
    Console.WriteLine("2. Paper");
    Console.WriteLine("3. Scissors");

    string? userInput = Console.ReadLine();
    if (userInput == "1")
    {
      Console.WriteLine("rock");
      return "rock";
    }
    else if (userInput == "2")
    {
      Console.WriteLine("paper");
      return "paper";
    }
    else if (userInput == "3")
    {
      Console.WriteLine("scissors");
      return "scissors";
    }
    else
    {
      return ChooseHand();
    }
  }
  public static string GetComputerHand()
  {
    int randomNumber = new Random().Next(1, 4);
    Console.WriteLine(randomNumber);
    if (randomNumber == 1)
    {
      Console.WriteLine("rock");
      return "rock";
    }
    if (randomNumber == 2)
    {
      Console.WriteLine("paper");
      return "paper";
    }
    Console.WriteLine("scissors");
    return "scissors";
  }
  public static void PlayAgain()
  {
    Thread.Sleep(2000);
    Console.Clear();
    Console.WriteLine($"Current Score you:{PlayerWins} - Opponent:{ComputerWins}");
    Console.WriteLine("Play Again?");
    Console.WriteLine("y/n");
    char userReset = Console.ReadKey().KeyChar;
    if (userReset == 'y')
    {
      Main();
    }
    else if (userReset == 'n')
    {
      Environment.Exit(0);
    }
    else
    {

      PlayAgain();
    }
  }
}
internal class SaveData
{
  public int PlayerWins { get; set; }
  public int ComputerWins { get; set; }

  public SaveData(int PlayerWins, int ComputerWins)
  {
    // PlayerWins = playerWins;
    // ComputerWins = computerWins;
  }
}