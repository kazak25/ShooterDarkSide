using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectHandler : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public ParticleSystem _blood;

    private float hitEffectDuration = 3f;
   // [SerializeField] public ParticleSystem _fire;
    

    public void ShowEffectBlood(Vector3 hitPosition, Vector3 normal)
    {
        var hiteffect = Instantiate(_blood, hitPosition, Quaternion.LookRotation(normal));
        _blood.Play();
       
    }

    private IEnumerator DestroyEffect(GameObject effect, float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(effect); //
    }
    // public void ShowEffectFire(Vector3 hitPosition, Vector3 normal)
    // {
    //     var hiteffect = Instantiate(_fire, hitPosition, Quaternion.LookRotation(normal));
    //     _fire.Play();
    // }
    
}
