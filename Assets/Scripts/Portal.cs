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
            
            PlayerPrefs.SetInt("StarCountLevel" + (currentScene - 1).ToString() , player.DeathCount);
            PlayerPrefs.SetInt("GameLevel", player.Lvl);            
            SceneManager.LoadScene(currentScene + 1);
            
        }
    }
}
