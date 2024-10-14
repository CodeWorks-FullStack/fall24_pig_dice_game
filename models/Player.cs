namespace pig_dice_game.models;

// NOTE public is an access modifier that denotes that all of this code can be "imported" to other modules and accessed freely
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

  // NOTE below are all properties that will exist on the class
  public string Name { get; set; }

  public int Score { get; set; }

  public List<int> DiceRolls { get; set; }
}