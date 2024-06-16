using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetTrigger : MonoBehaviour
{
    [SerializeField] private GameObject destroyEffectSystem;
    
    private void OnTriggerEnter(Collider other)
    {
        Instantiate(destroyEffectSystem).transform.position = transform.position;
        Destroy(gameObject);
    }
}
