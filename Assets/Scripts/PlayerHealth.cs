using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float _startHealth=20f;
    public float _starhHealth2 => _startHealth;

    public bool IsAlive => _currentHealth > 0;
    public UnityEvent Died;
    public UnityEvent<float> DecreaseHealth;

    private float _currentHealth;

    private void Start()
    {
        _currentHealth = _startHealth;
    }

    public void TakeDamage(float damage)
    {
        DecreaseHealth.Invoke(_currentHealth);
        _currentHealth -= damage;
        if (_currentHealth <= 0)
        {
            Died?.Invoke();
        }
    }
    
    // Start is called before the first frame update


}
