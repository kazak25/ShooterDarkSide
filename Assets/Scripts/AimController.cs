using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimController : MonoBehaviour
{
   
[SerializeField] private Transform _aimTarget;
[SerializeField] private LayerMask _mask;
[SerializeField]
private Camera _mainCamera;


private void Update()
{ 
   var ray = _mainCamera.ScreenPointToRay(Input.mousePosition);    if (Physics.Raycast(ray, out var hitInfo, 1000, _mask))
   {
        _aimTarget.position = hitInfo.point;
        
    }
}
}
