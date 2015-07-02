using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerMaterialController : MonoBehaviour {

	public static PlayerMaterialController materialControl;

	public Material ballMaterial;
	public Material ballDefault;
	public GameObject player;

	void Awake()
	{
		if (materialControl == null) 
		{
			DontDestroyOnLoad (gameObject);
			materialControl = this;


		}
		else if (materialControl != this) 
		{
			Destroy(gameObject);
		}


	}

	void Start () 
	{
		if(GameObject.FindGameObjectWithTag ("GameMManager").activeSelf)
		{
			ballMaterial = ballDefault;
			ballDefault = GameController.control.ballDefault;
		}
	}
	
	void Update () 
	{
		if(player == null && GameObject.FindGameObjectWithTag ("Player") && GameObject.FindGameObjectWithTag ("GameMManager").activeSelf)
		{
			player = GameObject.FindGameObjectWithTag ("Player");
			player.GetComponent<Renderer>().material = ballMaterial;
		}

		if (ballMaterial.name == "BallC") 
		{
			if(GameObject.FindGameObjectWithTag ("Check1"))
			{
				GameObject.FindGameObjectWithTag ("Check1").GetComponent<Image>().enabled = true;
			}
			if(GameObject.FindGameObjectWithTag ("Check2"))
			{
				GameObject.FindGameObjectWithTag ("Check2").GetComponent<Image>().enabled = false;
			}
			if(GameObject.FindGameObjectWithTag ("Check3"))
			{
				GameObject.FindGameObjectWithTag ("Check3").GetComponent<Image>().enabled = false;
			}
		}
		if (ballMaterial.name == "BallC1") 
		{
			if(GameObject.FindGameObjectWithTag ("Check1"))
			{
				GameObject.FindGameObjectWithTag ("Check1").GetComponent<Image>().enabled = false;
			}
			if(GameObject.FindGameObjectWithTag ("Check2"))
			{
				GameObject.FindGameObjectWithTag ("Check2").GetComponent<Image>().enabled = true;
			}
			if(GameObject.FindGameObjectWithTag ("Check3"))
			{
				GameObject.FindGameObjectWithTag ("Check3").GetComponent<Image>().enabled = false;
			}
		}
		if (ballMaterial.name == "BallC3") 
		{
			if(GameObject.FindGameObjectWithTag ("Check1"))
			{
				GameObject.FindGameObjectWithTag ("Check1").GetComponent<Image>().enabled = false;
			}
			if(GameObject.FindGameObjectWithTag ("Check2"))
			{
				GameObject.FindGameObjectWithTag ("Check2").GetComponent<Image>().enabled = false;
			}
			if(GameObject.FindGameObjectWithTag ("Check3"))
			{
				GameObject.FindGameObjectWithTag ("Check3").GetComponent<Image>().enabled = true;
			}
		}
	}
}
