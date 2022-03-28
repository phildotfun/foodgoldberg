using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] Text gameState;

    [SerializeField] GameObject displayWin;
    [SerializeField] GameObject background;

    Scene currentScene;
    int sceneNumber;
    string nextSceneName;

    public void Start()
    {
        //get current scene
        //add one to it, and put it back to load the next scene
        currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        string[] sceneArray = sceneName.Split('_');
        sceneNumber = int.Parse(sceneArray[1]) + 1;
        nextSceneName = "Level_" + sceneNumber.ToString();
       
    }

    void Update()
    {
        ResetGame();
        WinState();
    }

    void WinState()
    {
        if (gameState.text == "Win")
        {

            Invoke("DisplayWin", 1);
            Invoke("LoadNextLevel", 6);
 
        }
    }

    void DisplayWin()
    {
        displayWin.SetActive(true);
        background.SetActive(true);
    }

    void LoadNextLevel()
    {
        SceneManager.LoadScene(nextSceneName);
    }


    //press R to reset to first level
    void ResetGame()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Level_1");
        }
    }
}
