using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public Slider volumeSlider;

	void Update () {
		GetComponent<AudioSource>().volume = volumeSlider.GetSliderPercent();
	}
}
