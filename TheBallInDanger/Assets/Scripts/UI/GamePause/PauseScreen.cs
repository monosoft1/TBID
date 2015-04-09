using UnityEngine;
using System.Collections;

public class PauseScreen : MonoBehaviour {

	public Canvas pauseMenu;
	public GameObject fadingAnim;
	public GameObject player;
	public int clicks = 1;

	public void EnterPauseScreen ()
	{
		if (pauseMenu.GetComponent<Canvas>().enabled == !true) //clicks == 1) 
		{
			//clicks = 2;
			pauseMenu.GetComponent<Canvas>().enabled = true;
			fadingAnim.GetComponent<Animator> ().enabled = true;
			player.GetComponent<Rigidbody>().mass = 1000000;
			player.GetComponent<Rigidbody>().isKinematic = true;
		} 
		else if (pauseMenu.GetComponent<Canvas>().enabled == true)//clicks == 2)
		{
			pauseMenu.GetComponent<Canvas>().enabled = !true;
			fadingAnim.GetComponent<Animator> ().enabled = false;
			player.GetComponent<Rigidbody>().mass = 1;
			player.GetComponent<Rigidbody>().isKinematic = false;
			//clicks = 1;
		}

	}
}
