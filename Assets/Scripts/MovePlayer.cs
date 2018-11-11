using UnityEngine;

namespace ObstaclePrototype
{
	public class MovePlayer : MonoBehaviour
	{
		public Transform player;
		public float forwardForce;
		public float sideForce;
	
		private void FixedUpdate () {
			var rb = player.GetComponent<Rigidbody>();
			rb.AddForce(0, 0, forwardForce*Time.deltaTime);
		
			if (Input.GetKey("a"))
			{
				rb.AddForce(-sideForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
			}
		
			if (Input.GetKey("d"))
			{
				rb.AddForce(sideForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
			}
			
			// restart game if the player fell from the ground.
			if (player.position.y < -1f)
			{
				FindObjectOfType<GameManager>().EndGame();
			}
		}
	}
}

