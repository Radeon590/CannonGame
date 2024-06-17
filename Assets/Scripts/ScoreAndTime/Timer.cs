using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Text timeText;

    private float _timer = 0;

    private void Start()
    {
        timeText.text = "0:00";
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        timeText.text = $"{Convert.ToInt32(_timer / 60)}:{Convert.ToInt32(_timer % 60)}";
    }
}
