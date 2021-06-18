using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager
{
    private GameManager _gameManager;
    private Canvas _canvas;
    private Button _startBtn;
    private GameObject _groupMenu;

    public UIManager()
    {
        _canvas = GameObject.Find("Canvas").GetComponent<Canvas>();

        _groupMenu = _canvas.transform.Find("Group_Menu").gameObject;

        _startBtn = _groupMenu.transform.Find("Button_Start").GetComponent<Button>();
        
        _startBtn.onClick.AddListener(StartGame);
    }

    public void Start()
    {
        _gameManager = Main.Instance.gameManager;
    }

    public void Update()
    {
        
    }

    private void StartGame()
    {
        _groupMenu.SetActive(false);
    }
}
