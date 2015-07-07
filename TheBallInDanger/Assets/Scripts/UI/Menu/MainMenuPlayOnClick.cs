using UnityEngine;
using System.Collections;

public class MainMenuPlayOnClick : MonoBehaviour {

	public void OnClick () 
	{
		StartCoroutine (PlayMusic ());

	}

	IEnumerator PlayMusic()
	{
		if(PlayerPrefs.GetInt ("Deaths") >= 1 && GameController.onceEntered == false)
		{
			PlayerPrefs.SetInt ("Deaths", 0);
			GameController.onceEntered = true;
		}
		if(GameController.onceEntered == false && PlayerPrefs.GetInt ("Deaths") <= 0)
		{

		}
		Initiate.Fade(GameController.control.nextLevel,Color.black,0.7f);
		GameObject.FindGameObjectWithTag ("GameMManager").SetActive (true);
		GameObject.FindGameObjectWithTag ("Player").transform.parent = GameObject.FindGameObjectWithTag ("GameMManager").transform;
		yield return new WaitForSeconds (1.5f);
		GameObject music = GameObject.FindGameObjectWithTag ("Music");
		music.GetComponentInChildren<AudioSource> ().enabled = true;
		music.GetComponentInChildren<AudioSource> ().Play ();
	}
}
