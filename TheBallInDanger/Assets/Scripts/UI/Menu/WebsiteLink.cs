﻿using UnityEngine;
using System.Collections;

public class WebsiteLink : MonoBehaviour {

	// Use this for initialization
	public void Clicked () 
	{
		if (gameObject.transform.parent.tag == "LinkUI") 
		{
			Application.OpenURL("http://hamza-abdullah.tk");
		}
		if (gameObject.transform.parent.tag == "EmailUI") 
		{
			Application.OpenURL("mailto:support@hamza-abdullah.tk");
		}
	}
}
