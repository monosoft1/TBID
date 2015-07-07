using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PointerDown : MonoBehaviour {

	public Sprite newSprite;

	public void StartDoing () 
	{
		transform.parent.GetComponent<Image> ().sprite = newSprite;
	}
}
