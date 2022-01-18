using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    public void QuitTheGame()
    {
        Application.Quit();
    }
    public void Play()
    {
        GameSceneManager.StartNewGame();
    }

}
