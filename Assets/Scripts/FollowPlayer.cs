using UnityEngine;

namespace ObstaclePrototype
{
	public class FollowPlayer : MonoBehaviour
	{
		public Transform player;
		public Vector3 offset;
	
		private void FixedUpdate ()
		{
			transform.position = offset + player.transform.position;
		}
	}
}
