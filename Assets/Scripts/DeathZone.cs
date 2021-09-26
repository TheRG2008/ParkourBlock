using UnityEngine;
using UnityEngine.SceneManagement;



public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>())
        {
            Player player = other.GetComponent<Player>();
            if (player.IsALife)
            {
                player.IsALife = false;
                player.Respawn();
                Debug.Log("1");
            }
            other.GetComponent<Player>().IsALife = true;

        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.GetComponent<Player>())
    //    {
    //        Player player = other.GetComponent<Player>();            
    //        player.DeathCount--;            

    //        PlayerPrefs.SetInt("CountDeath", player.DeathCount);


    //        int currentScene = SceneManager.GetActiveScene().buildIndex;
    //        SceneManager.LoadScene(currentScene);

    //    }
    //}
}
