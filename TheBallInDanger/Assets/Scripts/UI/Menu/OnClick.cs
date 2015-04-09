using UnityEngine;
using System.Collections;

public class OnClick : MonoBehaviour {
	
	public void Click () 
	{
		Initiate.Fade("PlayerSettings",Color.black,0.7f);
	}
}
