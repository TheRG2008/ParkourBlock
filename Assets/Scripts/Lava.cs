using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Lava : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>())
        {
            SceneManager.LoadScene(0);
        }
    }

    //private void OnCollisionEnter(Collision other)
    //{
    //    if (other.gameObject.GetComponent<PlayerController>())
    //    {
    //        SceneManager.LoadScene(0);
    //    }
    //}

}
