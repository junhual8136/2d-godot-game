using Godot;

public partial class PlayButton : Button	
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Pressed += (() => GetTree().ChangeSceneToFile("res://scenes/tutorial.tscn"));
	}
}
