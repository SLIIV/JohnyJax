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
        StartCoroutine(GameSceneManager.LoadSceneAsync(GameSceneManager.FIRST_GAME_SCENE_NUMBER));
    }

}
