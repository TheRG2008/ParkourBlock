using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private Transform _spawnPoint;
   

    private void Awake()
    {
        Player newPlayer = Instantiate(_player, _spawnPoint).GetComponent<Player>();
        newPlayer.SetSpawnPoint(_spawnPoint.position);
    }

}
