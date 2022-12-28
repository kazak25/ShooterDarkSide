using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private BulletsView _bulletsView;
    [SerializeField] private EnemiesView _enemiesView;
    [SerializeField] private EnemySpawner _enemySpawner;
    
    private void Start()
    {
        var muzzle = FindObjectOfType<Muzzle>();
        _bulletsView.Initialize(muzzle);
        
    }

    private void Awake()
    {
        _enemiesView.Initialize(_enemySpawner);
    }
}
