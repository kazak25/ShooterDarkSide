using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private PlayerController _player;
    [SerializeField] private Vector3 _offset;
   
        
    public void MoveAndLookAtPlayer()
    {
        transform.position = _player.transform.position + _offset;
        transform.LookAt(_player.transform);
    }
}
