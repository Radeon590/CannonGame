using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class TargetMovement : MonoBehaviour
{
    [SerializeField] private bool isAbleToMove = true;
    [SerializeField] private Vector3 currentPoint;
    //
    public float Speed;
    public Vector3 Point1;
    public Vector3 Point2;

    

    public void Initialize(float speed, Vector3 point1, Vector3 point2)
    {
        Speed = speed;
        Point1 = point1;
        Point2 = point2;
        //
        transform.position = Point1;
        currentPoint = Point2;
        //
        isAbleToMove = true;
    }

    void Update()
    {
        if (isAbleToMove)
        {
            if (Vector3.Distance(transform.position, currentPoint) < 1)
            {
                if (currentPoint == Point1)
                {
                    currentPoint = Point2;
                }
                else
                {
                    currentPoint = Point1;
                }
            }
            //Move
            float step = Speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, currentPoint, step);
        }
    }
}
