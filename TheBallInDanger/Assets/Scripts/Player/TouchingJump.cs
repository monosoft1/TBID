using System;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class TouchingJump : MonoBehaviour
{		
	public static TouchingJump control;

	public float m_JumpPower = 7;
	public Rigidbody player;
    public static bool isFalling = false;

	public void Start()
	{
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Rigidbody>();
	}

    public void Jumpit()
	{
		if (isFalling == false) 
		{
			player.AddForce(Vector3.up * m_JumpPower, ForceMode.Impulse);
			isFalling = true;
		}

	}

}
