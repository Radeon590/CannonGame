using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float lifetime = 10;

    private float _timer = 0;

    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > lifetime)
        {
            Destroy(gameObject);
        }
    }
}
