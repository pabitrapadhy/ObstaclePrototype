using UnityEngine;

namespace ObstaclePrototype
{
	public class PlayerCollision : MonoBehaviour
	{
		public MovePlayer movement;
		private void OnCollisionEnter(Collision other)
		{
			if (other.collider.CompareTag("Obstacle"))
			{
				Debug.Log("Collided with : " + other.collider.name);
				movement.enabled = false;
				
				// calling through GameManager
				FindObjectOfType<GameManager>().EndGame();
			}
		}
	}
}

