using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private SelectedWeaponHandler _weaponHandler;
    [SerializeField] private Guns[] _guns;
    [SerializeField] private Transform _target;
    
    private int _index;

    private void Start()
    {
      var selectedWeapon = _weaponHandler.GetLastWeapon();
      _index = GetSelectedCarIndex(selectedWeapon);
        ShowGun(_index);
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

    public void SelectWrapon()
    {
       _weaponHandler.SetLastSelectedWeapon(_guns[_index]);
    }

    private void ShowGun(int index)
    {
       //var g=  Instantiate(_guns[index],_target);
        foreach (var gun in _guns)
        {
            gun.gameObject.SetActive(false);
        }
        _guns[index].gameObject.SetActive(true);

    }

    public void LoadScene()
    {
        SceneManager.LoadSceneAsync("Shooter");
    }

    public int GetSelectedCarIndex(Guns gun)
    {
        for (var i = 0; i < _guns.Length; i++)
        {
            Debug.Log(_guns[i]);
            Debug.Log(gun);
            if (_guns[i]._prefab == gun._prefab)
            {
                Debug.Log(i);
                return i;
               
            }
        }

        return 0;
    }
    
    
}
