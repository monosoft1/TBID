using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PointerUp : MonoBehaviour {
	
	public Color color = Color.black;
	public string forWhom;
	public Sprite muteVolume;
	public Sprite normalVolume;

	public void StopDoing () 
	{
		if (forWhom == "Reload") 
		{
			Initiate.Fade (Application.loadedLevelName, color, 0.7f);
			StartCoroutine (ResetPosition ());
		} 
		else if (forWhom == "Volume") 
		{
			if(AudioListener.volume != 0)
			{
				AudioListener.volume = 0;
				transform.parent.GetComponent<Image>().sprite = muteVolume;
			}
			else if(AudioListener.volume == 0)
			{
				AudioListener.volume = 1;
				transform.parent.GetComponent<Image>().sprite = normalVolume;
			}
		}
	}

	IEnumerator ResetPosition()
	{
		Transform player = GameObject.FindGameObjectWithTag ("Player").transform;
		Transform startingPlatform = GameObject.FindGameObjectWithTag ("StartingPlatform").transform;

		yield return new WaitForSeconds (1.5f);
		player.position = new Vector3 (startingPlatform.position.x, startingPlatform.position.y + 3, startingPlatform.position.z);
		Destroy(player.gameObject.transform.parent.gameObject);
	}

}
