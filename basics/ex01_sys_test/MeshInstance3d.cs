using Godot;
using System;

public partial class MeshInstance3d : MeshInstance3D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("Ready!");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{ 
		Rotation += new Vector3(0, (float)0.01, 0);
	}
}
