using Godot;

public partial class Tutorial : Label
{
	// Called when the node enters the scene tree for the first time.
	
	private MainPlayer _player;
	private Label _text; 

	public override void _Ready()
	
	
	{
		_text = GetNode<Label>("/root/MvpLevel/CharacterBody2D/tutorial");	
		_player = GetParent() as MainPlayer;

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		switch (_player.tutorialStage)
		{
			case 0:
				_text.Text = "Press A or D to move Left or Right";
				break;
			case 1:
				_text.Text = "Hold left click to charge and leap";
				break;
			case 2:
				_text.Text = "Complete this simple tutorial";
				break;
		}
	}
}
