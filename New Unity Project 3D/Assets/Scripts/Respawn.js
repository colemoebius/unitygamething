#pragma strict

var SpawnPoint: Transform;

var player : GameObject;

function OnTriggerEnter(col : Collider)
{
	
	
		player.transform.position = SpawnPoint.position;
	
}