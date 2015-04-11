using UnityEngine;
using System.Collections;

public class VolumeAdjust : MonoBehaviour {

	public int volume;

	void Update()
	{
		//
	}

	public void Change (int newVolume) 
	{
		volume = newVolume;
	}
}
