using UnityEngine;
using System.Collections;

public class SettingsGoBack : MonoBehaviour {

	// Use this for initialization
	public void OnClick () 
	{
		Initiate.Fade("MainMenu",Color.black,0.7f);
	}
}
