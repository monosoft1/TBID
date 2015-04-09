using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour {

	public string scene;
	public Color myColor = Color.black;
	public GameObject winText;
	public AudioSource winSound;

	IEnumerator OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player") 
		{
			winSound.Play();
			yield return new WaitForSeconds (1);
			winText.GetComponent<Canvas>().enabled = true;
			Initiate.Fade(scene,myColor,0.9f);
			yield return new WaitForSeconds (1);
			col.transform.rotation = Quaternion.identity;
			col.transform.position = GameController.control.playerPosition = new Vector3 (GameObject.FindGameObjectWithTag ("StartingPlatform").transform.position.x, GameObject.FindGameObjectWithTag ("StartingPlatform").transform.position.y + 5, GameObject.FindGameObjectWithTag ("StartingPlatform").transform.position.z);

			//yield return new WaitForSeconds (2);

		}
	}
}
