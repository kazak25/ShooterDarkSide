using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSelect : MonoBehaviour
{
    [SerializeField] private Guns[] _guns;

    private int _index;

    private void Awake()
    {
        ShowGun(0);
    }

    public void ShowNext()
    {
        _index = (_index + 1) % _guns.Length;
        ShowGun(_index);
    }

    public void ShowPrevious()
    {
        _index = (_index - 1) % _guns.Length;
        ShowGun(_index);
    }

    public void SaveGun()
    {
        DontDestroyOnLoad(_guns[_index]);
    }

    private void ShowGun(int index)
    {
        foreach (var gun in _guns)
        {
            gun.gameObject.SetActive(false);
        }
        _guns[index].gameObject.SetActive(true);

    }
    
}
