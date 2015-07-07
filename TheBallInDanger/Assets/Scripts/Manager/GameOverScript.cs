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
	public bool shouldDie = true;

	void Awake () 
	{
//		if (Advertisement.isSupported) 
//		{
//			Advertisement.allowPrecache = true;
//			Advertisement.Initialize("27484", true);
//			if(Advertisement.isReady("pictureZone")) 
//			{
//				//Advertisement.Show("pictureZone");
//			}
//		} 
//		else
//		{
//			//Debug.Log("Platform not supported");
//		}
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	void Update()
	{
		if(GameObject.FindGameObjectWithTag ("GameMManager"))
		{
			if (shouldDie == true && player.transform.position.y <= GameObject.FindGameObjectWithTag ("StartingPlatform").transform.position.y - 8) 
			{
				StartCoroutine (Doer ());

			}
		}
	}

	IEnumerator Doer() 
	{
		GameObject gameFManager = GameObject.FindGameObjectWithTag("GameMManager");
		loseSound.Play ();
		Initiate.Fade (GameController.control.nextLevel, mycolor, 0.8f);
		yield return null;
		PlayerPrefs.SetInt ("Deaths", DeathManager.deathVal);
		Destroy (gameFManager);
		DeathManager.deathVal ++;
		if(GameObject.FindGameObjectWithTag ("Deaths"))
		{
			DeathManager.deathText.text = DeathManager.deathVal.ToString();
		}
		shouldDie = false;
	}


}

