using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
  [SerializeField]  private EnemyController _enemyController;
    [SerializeField] private PlayerMovement _controller;
    
    public UnityEvent DecreaseEnemiesEvent;
    
    public int CountEnemy=5;
    private List<EnemyController> _spawnedEnemy = new List<EnemyController>();
    
    private void OnDestroy()
    {
        foreach (var enemy in _spawnedEnemy)
        {
            enemy.EnemyDiedEvent -= DecreaseEnemiesCount;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < CountEnemy; i++)
        {
            
            var newEnemy = Instantiate(_enemyController);
            newEnemy.Initialize(_controller);
            _spawnedEnemy.Add(newEnemy);
            newEnemy.transform.position = new Vector3(Random.Range(10,20), 2f, Random.Range(71,90));
            newEnemy.EnemyDiedEvent += DecreaseEnemiesCount;
        }
    }

    public void DecreaseEnemiesCount()
    {
        CountEnemy--;
        DecreaseEnemiesEvent.Invoke();
    }
}