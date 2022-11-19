using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private BulletsView _bulletsView;
    [SerializeField] private EnemiesView _enemiesView;
    [SerializeField] private Weapon weapon;
    [SerializeField] private EnemySpawner _enemySpawner;
    
    private void Awake()
    {
        _bulletsView.Initialize(weapon);
        _enemiesView.Initialize(_enemySpawner);
    }

}
