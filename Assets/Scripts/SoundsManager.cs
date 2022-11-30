using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsManager : MonoBehaviour
{
    [SerializeField] private AudioSource _music; 
    // Start is called before the first frame update
    private void Awake()
    {
        _music.Play();
    }

    public void ShotSound()
    {
        _music.Play();
    }

}
