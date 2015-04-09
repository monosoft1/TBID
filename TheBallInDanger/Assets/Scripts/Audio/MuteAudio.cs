using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MuteAudio : MonoBehaviour {

	public string hoverTag;
	public string normalTag;
	
	public void Muting () 
	{
		Image imgdHover = GameObject.FindGameObjectWithTag (hoverTag).GetComponent<Image> ();
		Image imgNormal = GameObject.FindGameObjectWithTag (normalTag).GetComponent<Image> ();

		AudioListener.volume = 0;
	}
}
