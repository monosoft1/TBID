using UnityEngine;
using System.Collections;

public class MainMenOnclick : MonoBehaviour {

	public string lvl;

	public void OnClick () 
	{
		Initiate.Fade(lvl,Color.black,0.7f);
		GameObject.FindGameObjectWithTag ("Player").transform.parent = GameObject.FindGameObjectWithTag ("GameMManager").transform;
	}
}
