#pragma strict

var rotationSpeed = 100;
var jumpHeight = 8;
var jumpKey : KeyCode;

private var isFalling = false;

function Update ()
{
	//Handle ball rotation.
	var Hrotation : float = Input.GetAxis ("Horizontal");
	var Vrotation : float = Input.GetAxis ("Vertical");
	
//	var h : float = CrossPlatformInputManager.GetAxis("Horizontal");
//    var v : float = CrossPlatformInputManager.GetAxis("Verticle");
//    var jump = CrossPlatformInputManager.GetButton("Jump");

	
	var movement : Vector3 = new Vector3(Hrotation, 0.0f, Vrotation);
	
	GetComponent.<Rigidbody>().AddForce (movement * rotationSpeed * Time.deltaTime);
	
	if (Input.GetKeyDown(jumpKey) && isFalling == false)
	{
		GetComponent.<Rigidbody>().velocity.y = jumpHeight;
	}
	isFalling = true;
}

function OnCollisionStay ()
{
	isFalling = false;
}