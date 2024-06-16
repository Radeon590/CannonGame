using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMovement : MonoBehaviour
{
    [SerializeField] private Transform gun;
    [SerializeField] private Vector3 minBorder;
    [SerializeField] private Vector3 maxBorder;
    [SerializeField] private float rotateSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) && GetNormalizedRotation(transform).y > minBorder.y)
        {
            RotateCannon(Vector3.down);
        }
        if (Input.GetKey(KeyCode.D) && GetNormalizedRotation(transform).y < maxBorder.y)
        {
            RotateCannon(Vector3.up);
        } 
        if (Input.GetKey(KeyCode.W) && GetNormalizedRotation(gun).x > minBorder.x)
        {
            RotateGun(Vector3.left);
        }
        if (Input.GetKey(KeyCode.S) && GetNormalizedRotation(gun).x < maxBorder.x)
        {
            RotateGun(Vector3.right);
        }
    }

    private void RotateCannon(Vector3 eulerAngel)
    {
        eulerAngel *= rotateSpeed * Time.deltaTime;
        transform.Rotate(eulerAngel);
    }

    private void RotateGun(Vector3 eulerAngel)
    {
        eulerAngel *= rotateSpeed * Time.deltaTime;
        gun.Rotate(eulerAngel);
    }

    private Vector3 GetNormalizedRotation(Transform t)
    {
        Vector3 result = t.rotation.eulerAngles;
        if (result.x > 180)
        {
            result.x = result.x - 360;
        }

        if (result.y > 180)
        {
            result.y = result.y - 360;
        }

        return result;
    }
}
