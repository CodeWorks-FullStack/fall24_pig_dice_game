namespace pig_dice_game.models;

public class Player
{
  public string Name { get; set; }

  // NOTE unsigned int is positive only
  public uint Score { get; set; }
}