using Godot;
using System;

public partial class BucketArea : Area2D
{
	// Called when the node enters the scene tree for the first time.

	[Export]
	private ScoreUI ScoreUI; 

	[Export]
	public int points = 1; 

	private void OnBodyEntered(Node2D body)
	{
		GD.Print(points); 
	}
}
