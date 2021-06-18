using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public static Main Instance;
    public GameManager gameManager;
    public UIManager uiManager;

    private void Start()
    {
        if(Instance == null) Instance = this;
        else Destroy(gameObject);
        GetManager();
        uiManager.Start();
        gameManager.Start();
    }
    public void GetManager()
    {
        gameManager = new GameManager();
        uiManager = new UIManager();
    }
    private void Update()
    {
        gameManager.Update();
        uiManager.Update();
    }
}
