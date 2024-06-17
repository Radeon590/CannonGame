using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMachine : MonoBehaviour
{
    [SerializeField] private GameObject menuObject;
    [SerializeField] private CannonMovement cannonMovement;
    [SerializeField] private TargetSpawner targetSpawner;
    [SerializeField] private Timer timer;
    
    public void StartGame()
    {
        menuObject.SetActive(false);
        targetSpawner.enabled = true;
        timer.enabled = true;
        cannonMovement.enabled = true;
    }
}
