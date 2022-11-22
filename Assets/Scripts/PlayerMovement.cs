using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 15;
    [SerializeField] private Animator _animator;
    [SerializeField] private CharacterController _character;
    
    public float gravity = -9.81f;
    private Vector3 _velocity;
    private float _currenttime;


    // Start is called before the first frame update

   
    private void Update()
    {
       
        var step = Time.deltaTime * _speed;
        
        
        if (Input.GetKey(KeyCode.W))
        {
            _animator.SetTrigger("Go");
        }
        
        

         
        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");
        var direction = (vertical * transform.forward + horizontal * transform.right)*step;
        _character.Move(new Vector3(direction.x, 0, direction.z));

        _velocity.y += gravity * Time.deltaTime;
        _character.Move(_velocity * Time.deltaTime);
        
        
    }

    public void ChangeRadius()
    {
        _character.radius = 0.3f;
        transform.Rotate(-40,71,-5);
    }
}