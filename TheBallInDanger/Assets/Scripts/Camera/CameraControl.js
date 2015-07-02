#pragma strict


var distance = -10;
var lift = 1.5;


function Update () 
{
    if(GameObject.FindGameObjectWithTag("Player"))
    {
        var baLL = GameObject.FindGameObjectWithTag("Player");
	    transform.position = baLL.transform.position + Vector3(0, lift, distance);
	    transform.LookAt (baLL.transform.position);
    }
}