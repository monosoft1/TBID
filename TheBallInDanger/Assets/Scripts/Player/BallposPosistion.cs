using UnityEngine;
using System.Collections;

public class BallposPosistion : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		GameObject ballposPositionPosition = GameObject.FindGameObjectWithTag("BallDefaultPositionPosition");
		gameObject.transform.position = ballposPositionPosition.transform.position;
	}
}
