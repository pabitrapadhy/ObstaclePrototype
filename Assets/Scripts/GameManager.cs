using UnityEngine;
using UnityEngine.SceneManagement;

namespace ObstaclePrototype
{
    public class GameManager : MonoBehaviour
    {
        private bool _gameEnded = false;

        public float startDelayTime;
        public GameObject levelCompleteUI;
        public GameObject player;

        public void LevelCompleted()
        {
            levelCompleteUI.SetActive(true);
            player.SetActive(false);
        }
        
        public void EndGame()
        {
            if (_gameEnded) return;

            Debug.Log("pabitra: game restarted");
            _gameEnded = true;
            Invoke("RestartGame", startDelayTime);
        }

        private void RestartGame()
        {
            Debug.Log("pabitra: game restarted");
            levelCompleteUI.SetActive(false);
            player.SetActive(true);
            SceneManager.LoadScene("SampleScene");
            _gameEnded = false;
        }
    }
}

