using Godot;
using System;

public partial class Area2d : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		BodyEntered += openCompleteScreen;
	}

	private void openCompleteScreen(Node2D body)
	{
		if (body.IsInGroup("player"))
		{
			GetTree().ChangeSceneToFile("res://scenes/levelComplete.tscn");

		}

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
