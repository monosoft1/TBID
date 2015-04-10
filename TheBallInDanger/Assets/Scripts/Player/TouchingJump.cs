using UnityEngine;
using System.Collections;

public class TouchingJump : MonoBehaviour {

	[SerializeField] public bool isFalling = false;
	private Rigidbody m_Rigidbody;

	// Update is called once per frame
	public void OnPointerUp() 
	{
		m_Rigidbody = GameObject.FindGameObjectWithTag ("Player").GetComponent<Rigidbody>();

		if (isFalling == false)
		{
			m_Rigidbody.AddForce(Vector3.up * 7, ForceMode.Impulse);
		}
		isFalling = true;
	}

	public void OnCollisionStay ()
	{
		isFalling = false;	
	}
}
