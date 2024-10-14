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
  }

  static Player AddPlayer()
  {
    Console.WriteLine($"Enter name for player {Players.Count + 1}");

    string playerName = Console.ReadLine();

    Player newPlayer = new Player(playerName);
    return newPlayer;
  }
}