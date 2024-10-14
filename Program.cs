// roll dice as many times as i want
// trying to get a score of 100
// i can stop rolling dice at any time to add all rolls to my score
// if you roll a 1, you can not add to your score and you pass to the next player

// NOTE using is very similar to import, but all public definitions under this namespace are imported instead of single values
using pig_dice_game.models;

internal class Program
{
  static List<Player> Players = [];


  // NOTE entry point to application
  static void Main()
  {
    Console.Clear();
    Console.WriteLine("PIG DICE GAME!!!!!");
    Player playerOne = AddPlayer();
    Players.Add(playerOne); // .push()
    Player playerTwo = AddPlayer();
    Players.Add(playerTwo); // .push()

    // Count is similar to length
    for (int i = 0; i < Players.Count; i++)
    {
      Player player = Players[i];
      Console.WriteLine($"Player {i + 1} is " + player.Name);
    }

    bool gameIsWon = false;
    int index = 0;

    // while (gameIsWon == false)
    while (!gameIsWon)
    {
      Player player = Players[index];

      gameIsWon = RollDice(player);
      index++;

      // NOTE if you reach the end of the array
      if (index == Players.Count)
      {
        index = 0;
      }
    }

    Player? winner = Players.Find(player => player.Score == 100);
    if (winner == null)
    {
      throw new Exception("What happened");
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{winner.Name} is the winner!");
  }

  static Player AddPlayer()
  {
    Console.WriteLine($"Enter name for player {Players.Count + 1}");

    string? playerName = Console.ReadLine();
    if (playerName == null)
    {
      throw new Exception("No player name!");
    }

    Player newPlayer = new Player(playerName);
    return newPlayer;
  }

  static bool RollDice(Player player)
  {
    Console.Clear();
    Console.WriteLine($"Rolling for {player.Name} | Score: {player.Score}");
    int randomNumber = new Random().Next(1, 7);
    player.DiceRolls.Add(randomNumber);

    // NOTE Console.Write will print out inline
    player.DiceRolls.ForEach(roll => Console.Write(roll + " "));
    Console.WriteLine();

    if (randomNumber == 1)
    {
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine("UH OH YOU ROLLED A ONE!");
      player.DiceRolls.Clear();
      Thread.Sleep(1000);
      Console.ResetColor();
      return false;
    }

    if (player.Score + player.DiceRolls.Sum() >= 100)
    {
      player.Score = 100;
      return true;
    }

    Console.WriteLine("Do you want to roll again? y/n");

    var userInput = Console.ReadKey().KeyChar;

    Console.WriteLine(userInput);

    if (userInput == 'y')
    {
      return RollDice(player);
    }

    // NOTE sum will total a list of ints
    player.Score += player.DiceRolls.Sum();
    // NOTE removes all entries in list
    player.DiceRolls.Clear();


    return false;
  }
}