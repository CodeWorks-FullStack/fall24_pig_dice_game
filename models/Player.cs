namespace pig_dice_game.models;

public class Player
{
  // NOTE this is the constructor of the Player class
  public Player(string name)
  {
    // this.Name = name;
    Name = name;
    Score = 0;
  }

  public string Name { get; set; }

  // NOTE unsigned int is positive only
  public uint Score { get; set; }
}