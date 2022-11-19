using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemiesView : MonoBehaviour
{
    [SerializeField] private Image _imagePrefab;

    private List<Image> _images = new List<Image>();
    private int _killedEnemies; //сколько врагов убито
    private EnemySpawner _enemySpawner;
    private int _countEnemy;


    public void Initialize(EnemySpawner enemySpawner)
    {
        _enemySpawner = enemySpawner;
    }

    // Start is called before the first frame update
    void Start()
    {
        _countEnemy = _enemySpawner.CountEnemy;
        for (int i = 0; i < _countEnemy; i++)
        {
            var prefab = Instantiate(_imagePrefab, transform);
            _images.Add(prefab);
        }
    }
    

    public void DestroyIcon()
    {
        Destroy(_images[_countEnemy - 1 - _killedEnemies]);
        _killedEnemies++;
    }
}