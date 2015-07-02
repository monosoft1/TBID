using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public static ScoreManager scoreC;

	public Text scoreText;
	public static int scoreVal;
	[SerializeField]int scoreValT = 0;

	void Start () 
	{
		scoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
		scoreVal = 0;
	}
	
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "Tile" | col.gameObject.tag == "ScorePlatform")
		{
			scoreVal ++;
			scoreText.text = ScoreManager.scoreVal.ToString();
			scoreValT = ScoreManager.scoreVal;
		}
		if(col.gameObject.tag == "EndPlatform")
		{
			scoreVal += 10;
			scoreText.text = ScoreManager.scoreVal.ToString();
			scoreValT = ScoreManager.scoreVal;
		}
	}
}
