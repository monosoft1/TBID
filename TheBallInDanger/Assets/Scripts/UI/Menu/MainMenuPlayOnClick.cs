using UnityEngine;
using System.Collections;

public class MainMenuPlayOnClick : MonoBehaviour {

	public void OnClick () 
	{
		StartCoroutine (PlayMusic ());

	}

	IEnumerator PlayMusic()
	{
		Initiate.Fade(GameController.control.nextLevel,Color.black,0.7f);
		GameObject.FindGameObjectWithTag ("GameMManager").SetActive (true);
		GameObject.FindGameObjectWithTag ("Player").transform.parent = GameObject.FindGameObjectWithTag ("GameMManager").transform;
		yield return new WaitForSeconds (1.5f);
		GameObject music = GameObject.FindGameObjectWithTag ("Music");
		music.GetComponentInChildren<AudioSource> ().enabled = true;
		music.GetComponentInChildren<AudioSource> ().Play ();
	}
}
