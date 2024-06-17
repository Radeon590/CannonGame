using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TargetTrigger : MonoBehaviour
{
    [SerializeField] private GameObject destroyEffectSystem;
    [SerializeField] private UnityEvent onTrigger;
    
    private void OnTriggerEnter(Collider other)
    {
        Instantiate(destroyEffectSystem).transform.position = transform.position;
        onTrigger?.Invoke();
        Destroy(gameObject);
    }
}
