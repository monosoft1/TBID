using UnityEngine;
using System.Collections;

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
		ballMaterial = ballDefault;
		
		
		player.GetComponent<Renderer>().material = ballMaterial;
		ballDefault = GameController.control.ballDefault;

	}
	
	void Update () 
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		player.GetComponent<Renderer>().material = ballMaterial;
	}
}
