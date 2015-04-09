using UnityEngine;
using System.Collections;

public class DontVanish : MonoBehaviour {

	void Awake () {
		DontDestroyOnLoad (transform.gameObject);
	}
}
