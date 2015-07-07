using UnityEngine;
using System.Collections;

public class dreamloLeaderBoard : MonoBehaviour {
	
	string dreamloWebserviceURL = "http://dreamlo.com/lb/";
	
	public string privateCode = "";
	public string publicCode = "";
	
	string highScores;
	
	////////////////////////////////////////////////////////////////////////////////////////////////
	
	// A player named Carmine got a score of 100. If the same name is added twice, we use the higher score.
 	// http://dreamlo.com/lb/(your super secret very long code)/add/Carmine/100

	// A player named Carmine got a score of 1000 in 90 seconds.
 	// http://dreamlo.com/lb/(your super secret very long code)/add/Carmine/1000/90
	
	// A player named Carmine got a score of 1000 in 90 seconds and is Awesome.
 	// http://dreamlo.com/lb/(your super secret very long code)/add/Carmine/1000/90/Awesome
	
	////////////////////////////////////////////////////////////////////////////////////////////////
	
	
	public struct Score {
		public string playerName;
		public int score;
		public int seconds;
		public string shortText;
	}
	
	public static dreamloLeaderBoard GetSceneDreamloLeaderboard()
	{
		GameObject go = GameObject.Find("dreamloLeaderboard");
		
		if (go == null) return null;
		
		return go.GetComponent<dreamloLeaderBoard>();
	}
	
	public void AddScore(string playerName, int totalScore)
	{
		StartCoroutine(AddScoreWithPipe(playerName, totalScore));
	}
	
	public void AddScore(string playerName, int totalScore, int totalSeconds)
	{
		StartCoroutine(AddScoreWithPipe(playerName, totalScore, totalSeconds));
	}
	
	public void AddScore(string playerName, int totalScore, int totalSeconds, string shortText)
	{
		StartCoroutine(AddScoreWithPipe(playerName, totalScore, totalSeconds, shortText));
	}
	
	// This function saves a trip to the server. Adds the score and retrieves results in one trip.
	IEnumerator AddScoreWithPipe(string playerName, int totalScore)
	{
		playerName = Clean(playerName);
		
		WWW www = new WWW(dreamloWebserviceURL + privateCode + "/add-pipe/" + WWW.EscapeURL(playerName) + "/" + totalScore.ToString());
		yield return www;
		highScores = www.text;
	}
	
	IEnumerator AddScoreWithPipe(string playerName, int totalScore, int totalSeconds)
	{
		playerName = Clean(playerName);
		
		WWW www = new WWW(dreamloWebserviceURL + privateCode + "/add-pipe/" + WWW.EscapeURL(playerName) + "/" + totalScore.ToString()+ "/" + totalSeconds.ToString());
		yield return www;
		highScores = www.text;
	}
	
	IEnumerator AddScoreWithPipe(string playerName, int totalScore, int totalSeconds, string shortText)
	{
		playerName = Clean(playerName);
		shortText = Clean(shortText);
		
		WWW www = new WWW(dreamloWebserviceURL + privateCode + "/add-pipe/" + WWW.EscapeURL(playerName) + "/" + totalScore.ToString() + "/" + totalSeconds.ToString()+ "/" + shortText);
		yield return www;
		highScores = www.text;
	}
	
	IEnumerator GetScores()
	{
		highScores = "";
		WWW www = new WWW(dreamloWebserviceURL +  publicCode  + "/pipe");
		yield return www;
		highScores = www.text;
	}
	
	public void LoadScores()
	{
		StartCoroutine(GetScores());
	}

	
	public string[] ToStringArray()
	{
		if (this.highScores == "") return null;
		
		string[] rows = this.highScores.Split(new char[] {'\n'}, System.StringSplitOptions.RemoveEmptyEntries);
		return rows;
	}
	
	public Score[] ToScoreArray()
	{
		string[] rows = ToStringArray();
		if (rows == null) return null;
		
		int rowcount = rows.Length;
		
		if (rowcount <= 0) return null;
		
		Score[] scoreList = new Score[rowcount];
		
		for (int i = 0; i < rowcount; i++)
		{
			string[] values = rows[i].Split(new char[] {'|'}, System.StringSplitOptions.RemoveEmptyEntries);
			
			Score current = new Score();
			current.playerName = values[0];
			current.score = 0;
			current.seconds = 0;
			current.shortText = "";

			if (values.Length > 1) current.score = CheckInt(values[1]);
			if (values.Length > 2) current.seconds = CheckInt(values[2]);
			if (values.Length > 3) current.shortText = values[3];
			
			scoreList[i] = current;
		}
		
		return scoreList;
	}
	
	
	
	// Keep pipe and slash out of names
	
	string Clean(string s)
	{
		s = s.Replace("/", "");
		s = s.Replace("|", "");
		return s;
		
	}
	
	int CheckInt(string s)
	{
		int x = 0;
		
		int.TryParse(s, out x);
		
		return x;
	}
	
}
