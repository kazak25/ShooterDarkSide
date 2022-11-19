using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    private float _damage = 1f;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider collider)
    {
        var playerHealth = collider.gameObject.GetComponent<PlayerHealth>();
        
        if (playerHealth)
        {
            playerHealth.TakeDamage(_damage);
        }
    }
}
