using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private NavMeshAgent _agent;


    public Action EnemyDiedEvent;

    private float _speed = 2;
    private PlayerMovement _controller;


    [UsedImplicitly]
    public void Initialize(PlayerMovement enemyController)
    {
        _controller = enemyController;
    }

    private void Update()
    {
        var step = Time.deltaTime * _speed;
        _agent.destination = _controller.transform.position;
       // transform.position = Vector3.MoveTowards(transform.position, _controller.transform.position, step);
        transform.LookAt(_controller.transform.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<PlayerHealth>())
        {
            _animator.SetTrigger("Hit");
        }
    }

    private void OnDestroy()
    {
        EnemyDiedEvent.Invoke();
    }
}