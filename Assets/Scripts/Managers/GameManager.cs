using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{


    public bool isGameStarted;
    
    public GameManager()
    {
        
    }

    public void Start()
    {
        isGameStarted = false;
    }

    public void Update()
    {
        
    }

    public void StartGame()
    {
        isGameStarted = true;
    }
}
