using Godot;
using System;

public partial class DestoryArea : Area2D
{
	private void OnBodyEntered(Node2D body)
	{
		body.QueueFree();
		GD.Print($"Destory object: {body.Name}"); 
	}
}
