using UnityEngine;
using System.Collections;

public class EManager : MonoBehaviour 
{
    
	public Transform movingPlatform;
	public Transform origin;
	public Transform destination;
	public Vector3 newPosition;
	public string currentState;
	public float smooth;
	public float resetTime;

	// Use this for initialization
	void Start () 
	{
		ChangeTarget ();

	}

	void FixedUpdate () 
	{
		movingPlatform.position = Vector3.Lerp (movingPlatform.position, newPosition, smooth * Time.deltaTime); 
	}

	void ChangeTarget()
	{
		if (currentState == "Moving To Origin") 
		{
			currentState = "Moving To Destination";
			newPosition = destination.position;
		}
		else if (currentState == "Moving To Destination") 
		{
			currentState = "Moving To Origin";
			newPosition = origin.position;
		}
		else if (currentState == "") 
		{
			currentState = "Moving To Destination";
			newPosition = destination.position;
		}
		Invoke("ChangeTarget", resetTime);
	}
}
