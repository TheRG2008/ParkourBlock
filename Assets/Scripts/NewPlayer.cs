using UnityEngine;
using UnityEngine.SceneManagement;

public class NewPlayer : MonoBehaviour
{
    public void GetNewPlayer()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(0);
    }
  
}
