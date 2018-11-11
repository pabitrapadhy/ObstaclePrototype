using UnityEngine;
using UnityEngine.UI;

namespace ObstaclePrototype
{
	public class Score : MonoBehaviour
	{
		public Transform player;
		public Text score;
	
		private void Update ()
		{
			var posZ = player.position.z;
			score.text = posZ.ToString("0");
		}
	}
}

