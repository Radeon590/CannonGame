using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private Text currentScoreText;
    [SerializeField] private Text maxScoreCounter;

    private int _currentScore = 0;
    
    public static ScoreCounter SingletonScoreCounter { get; private set; }

    private void Start()
    {
        SingletonScoreCounter = this;
        currentScoreText.text = $"{_currentScore}";
        maxScoreCounter.text = $"{PlayerPrefs.GetInt("score", 0)}";
    }

    public void AddPoint()
    {
        _currentScore++;
        currentScoreText.text = $"{_currentScore}";
        if (_currentScore > PlayerPrefs.GetInt("score", 0))
        {
            PlayerPrefs.SetInt("score", _currentScore);
            maxScoreCounter.text = $"{_currentScore}";
        }
    }
}
