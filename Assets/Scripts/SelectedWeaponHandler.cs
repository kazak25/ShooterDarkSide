using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedWeaponHandler : MonoBehaviour
{
    [SerializeField] private Guns[] _guns;
    private Dictionary<string, Guns> _gunsPrefabs = new ();
    
    // Start is called before the first frame update
    private void Awake()
    {
        foreach (var gun in _guns)
        {
            _gunsPrefabs.Add(gun.name,gun);
        }
        DontDestroyOnLoad(this);
    }

    public Guns GetLastWeapon()
    {
        var weaponPrefs = PrefsManager.Load();
        Debug.Log(_gunsPrefabs.ContainsKey(weaponPrefs));
        return _gunsPrefabs.ContainsKey(weaponPrefs) ? _gunsPrefabs[weaponPrefs] : _guns[0];
    }

    public void SetLastSelectedWeapon(Guns gun) // передаем gun для сохроанения и вызываем Save
    {
        Debug.Log("Сохраняем");
        Debug.Log(gun._prefab.name);
        PrefsManager.Save(gun._prefab.name);
    }
}
