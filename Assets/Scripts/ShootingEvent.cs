using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShootingEvent : MonoBehaviour
{
    
  public UnityEvent<float> ShootingEvent1;
  private Muzzle _gun;


  public void Initialize(Muzzle gun)
  {
      _gun = gun;
  }
  
  private float _shotCount = 1;
  private float _ammoCount;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
       // _guns.transform.position = _target.position;
        
    }
}
