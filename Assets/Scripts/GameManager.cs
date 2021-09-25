using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int LevelsCount = 30;
    
    private void Awake()
    {
        FirstLaunch();
       
    }

    private void FirstLaunch()
    {
        if (!PlayerPrefs.HasKey("StatusLevel1"))
        {
            PlayerPrefs.SetInt("LevelsCount", LevelsCount);
            for (int i = 0; i < LevelsCount; i++)
            {
                PlayerPrefs.SetInt("StatusLevel" + (i + 1).ToString(), 0);
            }
            PlayerPrefs.SetInt("StatusLevel", 1);
        }
    }
}
