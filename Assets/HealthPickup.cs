using UnityEngine;
using Gamekit3D;

public class HealthPickup : MonoBehaviour
{
    [SerializeField] private string requiredTag = "Player";
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == requiredTag)
        {
            other.GetComponent<Damageable>().ResetDamage();
        }
    }


}
