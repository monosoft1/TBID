using UnityEngine;
using System.Collections;

public class LeaderboardManager : MonoBehaviour {

	public string privateCode = "mhflgSAaWkSJlanWmCldwwpuaA7kdJk0S2KToHW8eusA";
	public string publicCode = "559b5ff36e51b615d0702d88";
	public string webURL = "http://dreamlo.com/lb/";

	int score = 10;
	string username = "Hamza";

	void Start()
	{
		DontDestroyOnLoad (gameObject);
		AddNewLeaderboard ("Hamza", 50);
		WWW www = new WWW(webURL + privateCode + "/add/" + WWW.EscapeURL (username) + "/" + score); //+ "/" + deaths + "/" + timeSpent + "/" + blocksPassed);

	}

	public void AddNewLeaderboard(string username, int score)
	{
		//StartCoroutine (UploadLeaderboardToDatabase (username, score));
	}

	IEnumerator UploadLeaderboardToDatabase(string username, int score)
	{
		WWW www = new WWW(webURL + privateCode + "/add/" + WWW.EscapeURL (username) + "/" + score); //+ "/" + deaths + "/" + timeSpent + "/" + blocksPassed);
		//WWW www = new WWW("http://dreamlo.com/lb/n30uhFHj1U2OsNvDIDLJKwojDX92JWs0KnhFdrFNT2tw/add/Hamza/100");
		yield return www;

		if(string.IsNullOrEmpty (www.error))
		{
			Debug.Log ("Leaderboard Successfully Uploaded!");
		}
		else
		{
			Debug.Log ("Error Uploading Leaderboard: " + www.error);
		}
	}

	IEnumerator DownloadLeaderboardFromDatabase(string username, int score)
	{
		WWW www = new WWW(webURL + publicCode + "/pipe/");
		yield return www;
		
		if(string.IsNullOrEmpty (www.error))
		{
			Debug.Log ("Leaderboard Successfully Downloaded!");
		}
		else
		{
			Debug.Log ("Error Downloading Leaderboard: " + www.error);
		}
//	}

//	public string username;
//	public int score;
//	public string[] top10Scores;
//	public string db_url="mysql.hostinger.co.uk";      // this is the path to our xampp database folder
//
//
//
//	IEnumerator SaveScores()
//	{
//		// first we create a new WWWForm, that means a "post" command goes out to our database (for futher information just google "post" and "get" commands for html/php
//		WWWForm form = new WWWForm();
//		
//		// with this line we will give a new name and save our score into that name
//		// those "" indicate a string and attach the score after the comma to it
//		form.AddField("Player Name", username);
//		form.AddField("Player Score", score);
//		
//		// the next line will start our php file that saves the Score and attaches the saved values from the "form" to it
//		// For this tutorial I've used a new variable "db_url" that stores the path
//		WWW webRequest = new WWW(db_url + "/" + "SaveLeaderboard.php", form);
//		
//		// with this line we'll wait until we get an info back
//		yield return webRequest;
	}
}
