using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTarget : MonoBehaviour
{
    public void AddPoints(int points)
    {
        ScoreCounter.SingletonScoreCounter.AddPoints(points);
    }
}
