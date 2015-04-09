using UnityEngine;
using System.Collections;

public class ExtraStuffChecker : MonoBehaviour {
	
	void Awake () 
	{
		GameObject canvas1 = GameObject.FindGameObjectWithTag ("BottomStrip");
		GameObject canvas2 = GameObject.FindGameObjectWithTag ("PauseMenuCanvas");
		GameObject pl = GameObject.FindGameObjectWithTag ("Player");

		GameObject music = GameObject.FindGameObjectWithTag ("Music");
		music.GetComponentInChildren<AudioSource> ().enabled = false;
		canvas1.GetComponent<Canvas> ().enabled = false;
		canvas2.GetComponent<Canvas> ().enabled = false;
		pl.GetComponent<Rigidbody>().isKinematic = true;
		pl.GetComponent<Renderer>().enabled = false;

		//GameObject ball = GameObject.FindGameObjectWithTag ("Player");
		//ball.renderer.enabled = false;
		//GameObject bS = GameObject.FindGameObjectWithTag ("BottomStrip");
		//bS.GetComponent<Canvas> ().enabled = false;
	}


}
