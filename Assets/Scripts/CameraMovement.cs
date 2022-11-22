using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update

    //[SerializeField] private PlayerMovement _player;
   // private GameObject _gun;
    [SerializeField] private Vector3 _offset;
    // Start is called before the first frame update
    // public void Initialize(GameObject player)
    // {
    //     _gun = player;
    // }
    //
    
    public void MoveAndLookAtPlayer(PlayerMovement player)
    {
        transform.position = player.transform.position + _offset;
        transform.LookAt(player.transform);
    }
   

  
}