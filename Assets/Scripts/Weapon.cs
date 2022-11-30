using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Weapon : MonoBehaviour
{
    
    [SerializeField] private float _speedBullet = 38f;
    [SerializeField]public float _ammoCount=20;
    [SerializeField] private BulletBehavior _bullet;
    //private EffectHandler _effect;
    

    public UnityEvent<float> ShootingEvent;
    
    private float _shotCount = 1;

    // public void Initialize(EffectHandler effect)
    // {
    //     _effect = effect;
    // }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_ammoCount <= 0)
            {
                return;
            }
            var bullet = Instantiate(_bullet, transform.position, transform.rotation);
            bullet.GetComponent<Rigidbody>().velocity = transform.forward * _speedBullet;
            ShootingEvent.Invoke(_shotCount);
            //_effect.ShowEffectFire();
        }
    }
}