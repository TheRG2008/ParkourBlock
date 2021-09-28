using UnityEngine;
using UnityEngine.SceneManagement;



public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Player playerClass;
        if (/*other.GetComponent<Player>()*/ other.TryGetComponent(out playerClass))
        {
            //Player player = other.GetComponent<Player>();
            //if (playerClass.IsALife)
            //{
                //playerClass.IsALife = false;
                playerClass.Respawn();
                Debug.Log("1");
            //}
            //other.GetComponent<Player>().IsALife = true;
            //Physics.IgnoreCollision(other, GetComponent<Collider>());
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
