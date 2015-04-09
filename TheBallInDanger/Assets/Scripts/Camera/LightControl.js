#pragma strict

var target : Transform;
var lift = 1.5;

function Update () 
{
	transform.position = target.position + Vector2(0, lift);
	transform.LookAt (target);
}