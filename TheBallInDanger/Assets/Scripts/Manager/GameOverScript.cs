using UnityEngine;
using System.Collections;
using System.Reflection;
using UnityEngine.Advertisements;
//using UnityEditor; 
using System;

public class GameOverScript : MonoBehaviour {

	public Color mycolor = Color.black;
	public GameObject loseText;
	public AudioSource loseSound;
	public GameObject player;
	
	void Awake () 
	{
		if (Advertisement.isSupported) 
		{
			Advertisement.allowPrecache = true;
			Advertisement.Initialize("27484", true);
			if(Advertisement.isReady("pictureZone")) 
			{
				//Advertisement.Show("pictureZone");
			}
		} 
		else
		{
			Debug.Log("Platform not supported");
		}
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	void Update()
	{
		StartCoroutine (Doer ());
	}

	IEnumerator Doer() 
	{
		if (player.transform.position.y <= GameObject.FindGameObjectWithTag ("StartingPlatform").transform.position.y - 8) 
		{
			GameObject gameFManager = GameObject.FindGameObjectWithTag("GameMManager");
			loseSound.Play ();
			Initiate.Fade (GameController.control.nextLevel, mycolor, 0.8f);
			Destroy (gameFManager);
			yield return null;
			Debug.ClearDeveloperConsole();
		}
	}


}

