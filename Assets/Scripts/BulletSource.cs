using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;

[RequireComponent(typeof(ParticleSystem))]
public class BulletSource : MonoBehaviour
{
    [HideInInspector] public Transform Transform;
    [HideInInspector] public ParticleSystem ExplosionEffect;

    private void Start() 
    {
        Transform = gameObject.transform;
        ExplosionEffect = GetComponentInChildren<ParticleSystem>();
    }

   
}
