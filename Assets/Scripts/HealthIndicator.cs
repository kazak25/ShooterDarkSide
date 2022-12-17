using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthIndicator : MonoBehaviour
{
    [SerializeField]
    private Slider _healthBar;
    
    [SerializeField]
    private PlayerHealth _healthController;

    [SerializeField]
    private GameObject _fillArea;

    [SerializeField] private Animator _animator;

    private float _currentHealth;
    private float _maxHealth;

    private void Start()
    {
        _maxHealth = _healthController._starhHealth2;
        SetHealth(_maxHealth);
    }

    public void SetHealth(float currentHealth)
    {
        _healthBar.value = currentHealth / _maxHealth;

        if (_healthBar.value <= 0)
        {
            _fillArea.SetActive(false);
            _animator.SetBool("PlayerDied",true);
        }
    }
}