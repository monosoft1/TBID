#pragma strict

var maxFallDistance = -10;
var loseText : GameObject; 
public var loseSound : AudioSource;

function Update ()
{
	if (transform.position.y <= maxFallDistance)
	{
	   
	   HealthAsyn();
	    
	}
}

function HealthAsyn()
{
    gameObject.GetComponent.<AudioSource>().Play();
    yield WaitForSeconds (1);
//    loseText.active = true;
	yield WaitForSeconds (2);
    Application.LoadLevel(Application.loadedLevel);
}