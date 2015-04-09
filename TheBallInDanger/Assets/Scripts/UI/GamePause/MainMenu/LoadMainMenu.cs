using UnityEngine;
using System.Collections;

public class LoadMainMenu : MonoBehaviour {

	private string scene = "MainMenu";
	private Color col = Color.black;

	public void loadingMainMenu ()
	{
	    GameObject pl = GameObject.FindGameObjectWithTag ("Player");
    	Transform fgM = GameObject.FindGameObjectWithTag ("GameMManager").transform;

		pl.transform.parent = fgM;
		Initiate.Fade (scene,col,0.7f);
	}
}
