using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Adjust : MonoBehaviour {

	public Sprite newSprite;


	void Start () 
	{

		GameObject canvas1 = GameObject.FindGameObjectWithTag ("BottomStrip");
		GameObject pauseMenuCanvas = GameObject.FindGameObjectWithTag ("PauseMenuCanvas");
		GameObject pl = GameObject.FindGameObjectWithTag ("Player");

		//GameObject platform = GameObject.FindGameObjectWithTag ("StartingPlatorm");


		if (Application.loadedLevelName == "MainMenu") 
		{
			canvas1.GetComponent<Canvas> ().enabled = false;
			pauseMenuCanvas.GetComponent<Canvas> ().enabled = false;
			pl.GetComponent<Rigidbody>().isKinematic = true;
			pl.GetComponent<Renderer>().enabled = false;
		} 
		else 
		{
			canvas1.GetComponent<Canvas> ().enabled = true;
			pauseMenuCanvas.GetComponent<Canvas> ().enabled = false;
			pl.GetComponent<Rigidbody>().isKinematic = false;
		    pl.GetComponent<Rigidbody>().mass = 1;
		    pl.GetComponent<Renderer>().enabled = true;
			//GameController.control.playerPosition = new Vector3 (GameObject.FindGameObjectWithTag ("StartingPlatform").transform.position.x, GameObject.FindGameObjectWithTag ("StartingPlatform").transform.position.y + 5, GameObject.FindGameObjectWithTag ("StartingPlatform").transform.position.z);
			pl.transform.position = GameController.control.playerPosition;
	    }
   }

	void Update()
	{
		GameObject volume = GameObject.FindGameObjectWithTag ("Volume");
		if (AudioListener.volume == 0) 
		{
			volume.GetComponent<Image> ().sprite = newSprite;
		}
//		GameObject pl = GameObject.FindGameObjectWithTag ("Player");
//
//		pl.GetComponent<Renderer>().material = GameController.control.ballMaterial;
//		
//		GameController.control.ballDefault = GameController.control.ballMaterial;
	}

//	void Update()
//	{
//		GameObject pauseMenuCanvas = GameObject.FindGameObjectWithTag ("PauseMenuCanvas");
//
//		if (Input.GetKeyDown (KeyCode.Space) && pauseMenuCanvas.GetComponent<Canvas>().enabled == false) 
//		{
//			pauseMenuCanvas.GetComponent<Canvas>().enabled = true;
//		}
//		if (Input.GetKeyDown (KeyCode.Space) && pauseMenuCanvas.GetComponent<Canvas>().enabled == true) 
//		{
//			pauseMenuCanvas.GetComponent<Canvas>().enabled = false;
//		}
//	}
}