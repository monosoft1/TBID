using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TManager : MonoBehaviour {



	void OnCollisionExit (Collision col)
	{
		if(col.gameObject.tag == "Player")
		   {
			  GetComponent<Rigidbody>().useGravity = true;
			  GetComponent<Rigidbody>().isKinematic = false;
		   }
	}
	
}
