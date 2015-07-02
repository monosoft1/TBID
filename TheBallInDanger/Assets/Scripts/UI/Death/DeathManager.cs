using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DeathManager : MonoBehaviour {

	public static DeathManager DeathC;
	
	public static Text deathText;
	public static int deathVal;
	[SerializeField]int deathValT = 0;

	void Start () 
	{
		deathText = GameObject.FindGameObjectWithTag("Deaths").GetComponent<Text>();
		deathVal = 0;
	}

	void OnCollisionEnter (Collision col)
	{
		deathValT = ScoreManager.scoreVal;
	}
}
