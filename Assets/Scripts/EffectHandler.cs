using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectHandler : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]  ParticleSystem _blood;

    private float hitEffectDuration = 3f;
    [SerializeField]  ParticleSystem _fire;
    [SerializeField] GameObject _weaponFire;
    

    public void ShowEffectBlood(Vector3 hitPosition, Vector3 normal)
    {
        var hiteffect = Instantiate(_blood, hitPosition, Quaternion.LookRotation(normal));
        hiteffect.Play();
       
    }

    private IEnumerator DestroyEffect(GameObject effect, float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(effect); //
    }
    public void ShowEffectFire()
    {
        var fire = Instantiate(_fire, _weaponFire.transform);
        fire.Play();
    }
    
}
