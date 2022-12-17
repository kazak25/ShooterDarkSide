using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _runningSpeed;
    [SerializeField] private Transform _camera;
    [SerializeField] private CharacterController _character;
    [SerializeField] private Animator _animator;

    private float _gravity = -9.81f;
    private Vector3 _velocity;
    private static readonly int Left = Animator.StringToHash("Left");
    private static readonly int Right = Animator.StringToHash("Right");

    private void Update()
    {
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");

        var isRunning = Mathf.Abs(x) > 0 || Mathf.Abs(z) > 0;
        

        if (!isRunning)
        {
            return;
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            _animator.SetTrigger("Go");
            _animator.SetInteger("Speed",1);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            _animator.SetInteger("Speed",0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _animator.SetTrigger(Left);
            _animator.SetInteger("Speed",1);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            _animator.SetInteger("Speed",0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _animator.SetTrigger(Right);
            _animator.SetInteger("Speed",1);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            _animator.SetInteger("Speed",0);
        }
        
        
        
        var deltaAngle = Mathf.Atan2(x, z) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, _camera.rotation.eulerAngles.y + deltaAngle, 0);

        _character.Move(transform.forward*Time.deltaTime *_runningSpeed);
        _velocity.y += _gravity * Time.deltaTime;
        _character.Move(_velocity * Time.deltaTime);
    }
}
