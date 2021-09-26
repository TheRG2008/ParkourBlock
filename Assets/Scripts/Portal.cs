using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>())
        {
            int currentScene = SceneManager.GetActiveScene().buildIndex;
            Player player = other.GetComponent<Player>();
            //int countDeath = PlayerPrefs.GetInt("CountDeath");

            //PlayerPrefs.SetInt("StarCountLevel" + (currentScene - 1).ToString(), countDeath);
            PlayerPrefs.SetInt("StarCountLevel" + (currentScene - 1).ToString(), player.DeathCount);
            PlayerPrefs.SetInt("GameLevel", player.Lvl);
            PlayerPrefs.SetInt("StatusLevel" + (currentScene + 1).ToString(), 1);
            SceneManager.LoadScene(currentScene + 1);
            
        }
    }
}
