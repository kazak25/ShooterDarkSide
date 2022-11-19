using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   [SerializeField] private CameraMovement _camera;
   [SerializeField] private GameObject _weaponView;
   

   private void Awake()
   {
      _camera.Initialize(_weaponView);
   }
}
