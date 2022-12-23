using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guns : MonoBehaviour
{
    [SerializeField] public Muzzle _muzzle ;

    private void Awake()
    {
        _muzzle.gameObject.SetActive(false);
    }

    public float AmmoCount()
    {
        return _muzzle._ammoCount;
    }

    public void SetActiveMuzzle()
    {
        _muzzle.gameObject.SetActive(true);
    }
}
