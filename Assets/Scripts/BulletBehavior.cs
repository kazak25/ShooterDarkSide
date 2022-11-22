using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BulletBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Rigidbody _rigidbody;

    private void OnCollisionEnter(Collision collision)
    {
        var effect = collision.gameObject.GetComponent<EffectHandler>();
        _rigidbody.useGravity = true;
        if (effect)
        {
            for (int i = 0; i < collision.contactCount; i++)
            {
                var contact = collision.contacts[i];
               effect.ShowEffectBlood(contact.point, contact.normal);
            }

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        
        
        Destroy(gameObject);
        
    }
}