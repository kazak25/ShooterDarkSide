using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WeaponBehaviour : MonoBehaviour
{
    [SerializeField]
    private Transform _target;

    private Guns _gun;
    private float _shotCount = 1;
   
   public UnityEvent<float> ShootingEvent;

    private float _ammoCount;
    // Start is called before the first frame update
   

    private void Start()
    {
        var selectedWeaponHandler = FindObjectOfType<SelectedWeaponHandler>();
        var selectedWeapon = selectedWeaponHandler.GetLastWeapon();
        var weapon = Instantiate(selectedWeapon);
        _gun = FindObjectOfType<Guns>();
        // var _rigibody = _guns.GetComponent<Rigidbody>();
        // _rigibody.isKinematic = true;
       
      weapon.transform.SetParent(_target);
        weapon.transform.position = _target.position;
        _gun.SetActiveMuzzle();
    }

    private void Update()
    {
         if (Input.GetMouseButtonDown(0))
        {
            if (_gun.AmmoCount() <= 0)
            {
                return;
            }
            ShootingEvent.Invoke(_shotCount);
          
        }
    }
}
