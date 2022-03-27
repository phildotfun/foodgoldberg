using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField] Text gameState;

    [SerializeField] GameObject displayWin;
    [SerializeField] GameObject background;


    bool win;

    void Update()
    {
        WinState();
    }

    void WinState()
    {
        if (gameState.text == "Win")
        {

            Invoke("DisplayWin", 1);
 
        }
    }

    void DisplayWin()
    {
        displayWin.SetActive(true);
        background.SetActive(true);
    }
}
