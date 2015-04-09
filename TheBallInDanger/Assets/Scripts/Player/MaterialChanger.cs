using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MaterialChanger : MonoBehaviour {

	public Material material; 

	public void Change () 
	{
		PlayerMaterialController.materialControl.ballMaterial = material;
	}
}
