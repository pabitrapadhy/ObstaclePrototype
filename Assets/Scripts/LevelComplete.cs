using ObstaclePrototype;
using UnityEngine;

public class LevelComplete : MonoBehaviour {
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            Debug.Log("pabitra: level complete");
            FindObjectOfType<GameManager>().LevelCompleted();
        }
    }
}
