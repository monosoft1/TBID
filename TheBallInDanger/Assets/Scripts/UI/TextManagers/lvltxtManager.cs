using UnityEngine;
using System.Collections;

public class lvltxtManager : MonoBehaviour {
	

	void Update () 
	{
		gameObject.GetComponent<UnityEngine.UI.Text> ().text = Application.loadedLevelName;
	}
}
