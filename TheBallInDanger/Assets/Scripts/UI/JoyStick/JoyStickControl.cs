using UnityEngine;
using System.Collections;

public class JoyStickControl : MonoBehaviour {

//	public Joystick joyStickLeft = null;
//
//	// Use this for initialization
//	void Start () 
//	{
//		// this is to set the joysticks
//		if(joyStickLeft ==null){
//			GameObject objjoyStickLeft = GameObject.FindGameObjectWithTag("LeftJoystick") as GameObject;
//			joyStickLeft = objjoyStickLeft.GetComponent<Joystick>();
//		}
//	}
//	
//	// Update is called once per frame
//	void FixedUpdate () 
//	{
//		Vector3 position = this.transform.position;
//		
//		float xMovement = 0;
//		float yMovement = 0;
//		// this is to move the cube
//		if(joyStickLeft.transform.position.x<0) 
//		{ 			
//			xMovement = xMovement - 0.01f; 		
//		} 		
//		if(joyStickLeft.transform.position.x>0) 
//		{
//			xMovement = xMovement + 0.01f;
//		}
//		
//		if(joyStickLeft.transform.position.y<0) 
//		{ 			
//			yMovement = yMovement - 0.01f; 		
//		} 		
//		if(joyStickLeft.transform.position.y>0) 
//		{
//			yMovement = yMovement + 0.01f;
//			
//		}
//		
//		position.x = position.x+ xMovement;
//		position.z = position.z + yMovement;
//		this.transform.position = position;
//	}
//
//	    float joyStickInput (Joystick jstick) {
//		Vector2 absJoyPos =new Vector2 (Mathf.Abs(jstick.transform.position.x),
//		                                Mathf.Abs(jstick.transform.position.y));
//		int xDirection = (jstick.transform.position.x > 0) ? 1 : -1;
//		int yDirection = (jstick.transform.position.y > 0) ? 1 : -1;
//		return ( ( absJoyPos.x > absJoyPos.y) ? absJoyPos.x * xDirection : absJoyPos.y * yDirection);
//	}

	//flag to check if the user has tapped / clicked. 
	//Set to true on click. Reset to false on reaching destination
	private bool flag = false;
	//destination point
	private Vector3 endPoint;
	//alter this to change the speed of the movement of player / gameobject
	public float duration = 50.0f;
	//vertical position of the gameobject
	private float yAxis;
	
	void Start(){
		//save the y axis value of gameobject
		yAxis = gameObject.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		
		//check if the screen is touched / clicked   
		if((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) || (Input.GetMouseButtonDown(0)))
		{
			//declare a variable of RaycastHit struct
			RaycastHit hit;
			//Create a Ray on the tapped / clicked position
			Ray ray;
			//for unity editor
			#if UNITY_EDITOR
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			//for touch device
			#elif (UNITY_ANDROID || UNITY_IPHONE || UNITY_WP8)
			ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			#endif
			
			//Check if the ray hits any collider
			if(Physics.Raycast(ray,out hit))
			{
				//set a flag to indicate to move the gameobject
				flag = true;
				//save the click / tap position
				endPoint = hit.point;
				//as we do not want to change the y axis value based on touch position, reset it to original y axis value
				endPoint.y = yAxis;
				Debug.Log(endPoint);
			}
			
		}
		//check if the flag for movement is true and the current gameobject position is not same as the clicked / tapped position
		if(flag && !Mathf.Approximately(gameObject.transform.position.magnitude, endPoint.magnitude)){ //&& !(V3Equal(transform.position, endPoint))){
			//move the gameobject to the desired position
			gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, endPoint, 1/(duration*(Vector3.Distance(gameObject.transform.position, endPoint))));
		}
		//set the movement indicator flag to false if the endPoint and current gameobject position are equal
		else if(flag && Mathf.Approximately(gameObject.transform.position.magnitude, endPoint.magnitude)) {
			flag = false;
			Debug.Log("I am here");
		}
		
	}
}

