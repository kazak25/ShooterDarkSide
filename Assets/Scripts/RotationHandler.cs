using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationHandler : MonoBehaviour
{
    // Start is called before the first frame update

     [SerializeField]
     private float _mouseSensitivity = 10f;
     [SerializeField]
     private Transform _player;

     private float _mouseXMovement;
     private float _mouseYMovement;
     
     private void Awake()
     {
         Cursor.lockState = CursorLockMode.Locked;
     }
     private void Update()
     {
     
         _mouseXMovement = Input.GetAxis("Mouse X")*_mouseSensitivity*Time.deltaTime;
         _mouseYMovement -= Input.GetAxis("Mouse Y")*_mouseSensitivity*Time.deltaTime;
         _mouseYMovement = Mathf.Clamp(_mouseYMovement, -40, 40);
         _player.transform.localRotation = Quaternion.Euler(_mouseYMovement,0,0);
         transform.Rotate(0,_mouseXMovement,0);
         
     }
}
