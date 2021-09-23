using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void StartGame()
    {
        int currentLevl = PlayerPrefs.GetInt("GameLevel");
        if (currentLevl > 0)
        {
            SceneManager.LoadScene(currentLevl + 1);
        }
        else
        {
            SceneManager.LoadScene(1);
        }
        
    }
}
