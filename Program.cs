// roll dice as many times as i want
// trying to get a score of 100
// i can stop rolling dice at any time to add all rolls to my score
// if you roll a 1, you can not add to your score and you pass to the next player

internal class Program
{
  static List<string> PlayerNames = [];


  // NOTE entry point to application
  static void Main()
  {
    Console.Clear();
    Console.WriteLine("PIG DICE GAME!!!!!");
    string playerOneName = AddPlayer();
    PlayerNames.Add(playerOneName); // .push()
    string playerTwoName = AddPlayer();
    PlayerNames.Add(playerTwoName); // .push()

    // Count is similar to length
    for (int i = 0; i < PlayerNames.Count; i++)
    {
      string playerName = PlayerNames[i];
      Console.WriteLine(playerName);
    }
  }

  static string AddPlayer()
  {
    Console.WriteLine("Enter name for player");

    string playerName = Console.ReadLine();

    Console.WriteLine($"Player name is {playerName}");
    return playerName;
  }
}