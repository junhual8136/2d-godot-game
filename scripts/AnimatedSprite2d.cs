using Godot;
using System;

public partial class AnimatedSprite2d : AnimatedSprite2D
{
	private AnimatedSprite2d _animatedSprite;
	private static MainPlayer _player;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_animatedSprite = GetTree().CurrentScene.GetNode("CharacterBody2D/AnimatedSprite2D") as AnimatedSprite2d;
		// _animatedSprite = GetNode<AnimatedSprite2d>("AnimatedSprite2d");
		_animatedSprite.Play("idle");
		
		_player = GetParent() as MainPlayer;
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// changes animation when player is moving / idle
		// flipH makes the player turn the right direction

		if (!_player.IsOnFloor())
		{
			_animatedSprite.Play("jump");
			if (_player.Velocity.X < 0)
			{
				_animatedSprite.FlipH = true;
			}
			else
			{
				_animatedSprite.FlipH = false;
			}
		}
		
		else
		{
			if (Input.IsActionPressed("move_right"))
			{
				_animatedSprite.FlipH = false;
				_animatedSprite.Play("run");
			}
			else if (Input.IsActionPressed("move_left"))
			{
				_animatedSprite.FlipH = true;

				_animatedSprite.Play("run");
			}
			else
			{
				_animatedSprite.FlipH = false;
				_animatedSprite.Play("idle");
			}
		}
		
		
		
		
	}
}
