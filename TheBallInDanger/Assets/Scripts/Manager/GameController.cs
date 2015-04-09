using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;

public class GameController : MonoBehaviour {

	public static GameController control;

	public bool shouldStoreData;
	public string nextLevel;
	public Vector3 playerPosition;
	public Vector3 playerDPosition;

	public GameObject player;
	public GameObject mainCanvas;
	public GameObject pauseCanvas;

	public Material ballMaterial;
	public Material ballDefault;

	// Use this for initialization
	void Awake () 
	{
		if (control == null) 
		{
			nextLevel = "Level 1";
			DontDestroyOnLoad (gameObject);
			control = this;
//			ballMaterial = ballDefault;


			if (Application.loadedLevelName == "MainMenu") 
			{
				shouldStoreData = false;
			} 
			else if (Application.loadedLevelName == "PlayerSettings") 
			{
				shouldStoreData = false;
			} 
			else if (Application.loadedLevelName == "Settings") 
			{
				shouldStoreData = false;
			} 
			else if (Application.loadedLevelName == "Help") 
			{
				shouldStoreData = false;
			} 
			else 
			{
				shouldStoreData = true;
			}
			//playerPosition = new Vector3 (GameObject.FindGameObjectWithTag ("StartingPlatform").transform.position.x, GameObject.FindGameObjectWithTag ("StartingPlatform").transform.position.y + 5, GameObject.FindGameObjectWithTag ("StartingPlatform").transform.position.z);
			//playerDPosition = new Vector3 (GameObject.FindGameObjectWithTag ("StartingPlatform").transform.position.x, GameObject.FindGameObjectWithTag ("StartingPlatform").transform.position.y + 5, GameObject.FindGameObjectWithTag ("StartingPlatform").transform.position.z);
		} 
		else if (control != this) 
		{
			Destroy(gameObject);
		}
	}

	void Update()
	{
		if (Application.loadedLevelName == "MainMenu") 
		{
			shouldStoreData = false;
		} 
		else if (Application.loadedLevelName == "PlayerSettings") 
		{
			shouldStoreData = false;
		} 
		else if (Application.loadedLevelName == "Settings") 
		{
			shouldStoreData = false;
		} 
		else if (Application.loadedLevelName == "Help") 
		{
			shouldStoreData = false;
		} 
		else 
		{
			shouldStoreData = true;
		}
		if(shouldStoreData == true)
		{
			nextLevel = Application.loadedLevelName;
			playerPosition.x = player.transform.position.x;
			playerPosition.y = player.transform.position.y;
			playerPosition.z = player.transform.position.z;
			//player.GetComponent<Renderer>().material = ballMaterial;
		}

	}


	
}
