using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class BulletsView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    
    private Muzzle _weapon;
    private float _bulletCount;
    
    
  //  private float _bulletCount = 20;
  public void Initialize(Muzzle weapon)
  {
      _weapon = weapon;
  }
    
    public void Shoot(float num)
    {
        _bulletCount = _weapon._ammoCount;
        if (_weapon._ammoCount <= 0)
        {
            return;
        }
        _weapon._ammoCount -= num;
        
        _text.text = _weapon._ammoCount.ToString();
    }
}