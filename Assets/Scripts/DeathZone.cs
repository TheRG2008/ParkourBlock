using UnityEngine;



public class DeathZone : MonoBehaviour
{
    [SerializeField] private Transform _spawn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>())
        {
            other.GetComponent<Player>().Respawn();         

        }
    }
}
