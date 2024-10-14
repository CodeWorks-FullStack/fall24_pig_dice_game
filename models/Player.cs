namespace pig_dice_game.models;

public class Player
{
  // NOTE this is the constructor of the Player class
  public Player(string name)
  {
    // this.Name = name;
    Name = name;
    Score = 0;
    DiceRolls = [];
  }

  public string Name { get; set; }

  public int Score { get; set; }

  public List<int> DiceRolls { get; set; }
}