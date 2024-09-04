namespace BanchoSharp.Multiplayer;

public enum TeamColor
{
	Red,
	Blue,
	None
}

public class MultiplayerPlayer
{
	public int? Id { get; set; }
	public string Name { get; }
	public TeamColor Team { get; set; }
	public int Slot { get; set; }
	
	// The mods the player is using, these only get updated after "!mp settings" has been ran.
	public Mods Mods { get; set; }

	public int? Score { get; set; }
	public bool? Passed { get; set; }

	public MultiplayerPlayer(string name, int slot, TeamColor team = TeamColor.None, Mods mods = Mods.None)
	{
		Name = name;
		Slot = slot;
		Team = team;
		Mods = mods;
	}
}