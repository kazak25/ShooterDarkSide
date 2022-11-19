using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
   
    
    private GameObject _gun;
    [SerializeField] private Vector3 _offset;
    // Start is called before the first frame update
    public void Initialize(GameObject player)
    {
        _gun = player;
    }
    private void Update()
    {
        transform.rotation = _gun.transform.rotation;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = _gun.transform.position + _offset;
    }

  
}