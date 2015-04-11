using System;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Ball
{
	public class Ball : MonoBehaviour
    {


        [SerializeField] public float m_MovePower = 5; // The force added to the ball to move it.
        [SerializeField] private bool m_UseTorque = true; // Whether or not to use torque to move the ball.
        [SerializeField] private float m_MaxAngularVelocity = 25; // The maximum velocity the ball can rotate at.

		[SerializeField] public float m_JumpPower = 7; // The force added to the ball when it jumps.
		[SerializeField] public bool isFalling = false;

        private const float k_GroundRayLength = 1f; // The length of the ray to check if the ball is grounded.
        private Rigidbody m_Rigidbody;


        private void Start()
        {
			m_Rigidbody = GameObject.FindGameObjectWithTag ("Player").GetComponent<Rigidbody>();
            // Set the maximum angular velocity.
           GameObject.FindGameObjectWithTag ("Player").GetComponent<Rigidbody>().maxAngularVelocity = m_MaxAngularVelocity;
        }


        public void Move(Vector3 moveDirection, bool jump)
        {
            // If using torque to rotate the ball...
            if (m_UseTorque)
            {
                // ... add torque around the axis defined by the move direction.
                m_Rigidbody.AddTorque(new Vector3(moveDirection.z, 0, -moveDirection.x)*m_MovePower);
            }
            else
            {
                // Otherwise add force in the move direction.
                m_Rigidbody.AddForce(moveDirection*m_MovePower);
            }

            // If on the ground and jump is pressed...
            if (Physics.Raycast(transform.position, -Vector3.up, k_GroundRayLength) && jump)
            {
                // ... add force in upwards.
                m_Rigidbody.AddForce(Vector3.up * m_JumpPower, ForceMode.Impulse);
            }
        }

		public void Update()
		{
			float Hrotation = Input.GetAxis ("Horizontal");
			float Vrotation = Input.GetAxis ("Vertical");

			Vector3 m_Movement = new Vector3(Hrotation, 0.0f, Vrotation);
		
			m_Rigidbody.AddForce (m_Movement * 200 * Time.deltaTime);

			if (Input.GetKeyDown(KeyCode.Space) && isFalling == false)
			{
				m_Rigidbody.AddForce(Vector3.up * 7, ForceMode.Impulse);
			}
			isFalling = true;
		}
		public void OnCollisionStay ()
		{
			isFalling = false;
			TouchingJump.isFalling = false;
		}
    }
}
