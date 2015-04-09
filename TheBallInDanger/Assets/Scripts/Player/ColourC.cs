using UnityEngine;
using System.Collections;

public class ColourC : MonoBehaviour {

	public Material bM;

	void OnSetColour (Color color) 
	{
		//bM = new Material (GetComponent<Renderer> ().sharedMaterial);
		//bM.color = color;
		//GetComponent<Renderer> ().material = bM;
		//renderer.material.shader = Shader.Find("Diffuse");
		//renderer.material.SetColor("_Color", Color.red);
		//bM.color = color; 
		//bM = new Material (GetComponent<Renderer> ().sharedMaterial);
		//bM.color = color;
		//GetComponent<Renderer> ().material = bM;
		GetComponent<Renderer>().material.color = Color.black;
	}

	void OnGetColour (ColorPicker picker) 
	{
		//picker.NotifyColor (GetComponent<Renderer> ().material.color);
		GetComponent<Renderer>().material.color = Color.black;
	}
}
