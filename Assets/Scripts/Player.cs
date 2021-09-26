using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int _deathCount;
    private int _lvl;
    private Vector3 _firstPosition;
    private bool _isALife = true;

    public bool IsALife 
    {
        get => _isALife;
        set => _isALife = value;
    }

    public void Start()
    {       
        _deathCount = 3;
        _lvl = SceneManager.GetActiveScene().buildIndex;
    }
    public int DeathCount
    {
        get => _deathCount;
        set
        {
            _deathCount = value;
            if (_deathCount < 0)
            {
                _deathCount = 0;
            }
        }
    }
    public int Lvl 
    { 
        get => _lvl; 
        set => _lvl = value; 
    }

    public void SetSpawnPoint (Vector3 spawnPoint)
    {
        _firstPosition = spawnPoint;
    }

    public void Respawn()
    {       
        GetComponent<CharacterController>().enabled = false;
        transform.position = _firstPosition;
        GetComponent<CharacterController>().enabled = true;
        DeathCount--;       
    }




}
