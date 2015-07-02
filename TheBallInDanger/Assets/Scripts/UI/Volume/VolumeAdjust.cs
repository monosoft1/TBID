using UnityEngine;
using System.Collections;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeAdjust : MonoBehaviour {

	public AudioMixer masterMixer;
	
	public void SetMusicLvl(float musicLvl)
	{
		masterMixer.SetFloat ("musicVol", musicLvl);
		AudioMainManager.musicSliderValue = musicLvl;
	}

	public void SetEffectsLvl(float soundEffectsLvl)
	{
		masterMixer.SetFloat ("soundEffectsVolume", soundEffectsLvl);
		AudioMainManager.sfxSliderValue = soundEffectsLvl;
		GameObject.Find ("rollover_1").GetComponent<AudioSource>().Play ();
	}
}
