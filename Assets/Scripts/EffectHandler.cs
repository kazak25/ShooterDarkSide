using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectHandler : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public ParticleSystem _blood;
   // [SerializeField] public ParticleSystem _fire;
    

    public void ShowEffectBlood(Vector3 hitPosition, Vector3 normal)
    {
        var hiteffect = Instantiate(_blood, hitPosition, Quaternion.LookRotation(normal));
        _blood.Play();
    }
    // public void ShowEffectFire(Vector3 hitPosition, Vector3 normal)
    // {
    //     var hiteffect = Instantiate(_blood, hitPosition, Quaternion.LookRotation(normal));
    //     _blood.Play();
    // }
    
}
