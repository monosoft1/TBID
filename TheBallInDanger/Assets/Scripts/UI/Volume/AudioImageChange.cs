using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AudioImageChange : MonoBehaviour {

	public string hoverTag;
	public string normalTag;
	
	public void AudioIMG () 
	{
		Image imgHover = GameObject.FindGameObjectWithTag (hoverTag).GetComponent<Image> ();
		Image imgNormal = GameObject.FindGameObjectWithTag (normalTag).GetComponent<Image> ();

		if (imgHover.enabled == false && imgNormal.enabled == true) 
		{
			imgHover.enabled = true;
			imgNormal.enabled = false;
		}
		if (imgHover.enabled == true && imgNormal.enabled == false) 
		{
     		imgHover.enabled = false;
	    	imgNormal.enabled = true;
		}
	}
}
