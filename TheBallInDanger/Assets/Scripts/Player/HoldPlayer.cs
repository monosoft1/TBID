using UnityEngine;
using System.Collections;

public class HoldPlayer : MonoBehaviour {

	void OnTriggerEnter(Collider col)
	{
		col.transform.parent = gameObject.transform.parent;
	}
	void OnTriggerExit(Collider col)
	{
		col.transform.parent = GameObject.FindGameObjectWithTag("GameMManager").transform;
	}
}
