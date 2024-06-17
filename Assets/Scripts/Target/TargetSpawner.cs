using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> targetPrefabs;
    [SerializeField] private float spawnRate = 1;
    [SerializeField] private Transform leftDownPoint;
    [SerializeField] private Transform rightUpPoint;
    [SerializeField] private Vector2 speedLimits;

    private float _timer;
    
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > spawnRate)
        {
            int prefab = Random.Range(0, targetPrefabs.Count);
            float speed = Random.Range(speedLimits.x, speedLimits.y);
            Vector3 point1 = RandomizePoint();
            Vector3 point2 = RandomizePoint();
            Instantiate(targetPrefabs[prefab]).GetComponent<TargetMovement>().Initialize(speed, point1, point2);
            //
            _timer = 0;
        }
    }

    private Vector3 RandomizePoint()
    {
        return new Vector3(Random.Range(leftDownPoint.position.x, rightUpPoint.position.x),
            Random.Range(leftDownPoint.position.y, rightUpPoint.position.y),
            Random.Range(leftDownPoint.position.z, rightUpPoint.position.z));
    }
}
