using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AudioMainManager : MonoBehaviour {

	public static AudioMainManager control;
	
	public UnityEngine.UI.Slider musicSlider;
	public static  float musicSliderValue;
	[SerializeField]float musicSliderValueVal;

	public UnityEngine.UI.Slider sfxSlider;
	public static  float sfxSliderValue;
	[SerializeField]float sfxSliderValueVal;
	
	void Start () 
	{
		if(GameObject.Find ("AudioSettingsCanvas"))
		{
			musicSlider = GameObject.Find ("MusicSlider").GetComponent<UnityEngine.UI.Slider>();
			musicSlider.value = AudioMainManager.musicSliderValue;
			musicSliderValueVal = AudioMainManager.musicSliderValue;

			sfxSlider = GameObject.Find ("SFXSlider").GetComponent<UnityEngine.UI.Slider>();
			sfxSlider.value = AudioMainManager.sfxSliderValue;
			sfxSliderValueVal = AudioMainManager.sfxSliderValue;
		}
		else
		{
			musicSlider = null;
		}
	}

	void Update ()
	{
		musicSliderValueVal = AudioMainManager.musicSliderValue;
		sfxSliderValueVal = AudioMainManager.sfxSliderValue;
	}
}
