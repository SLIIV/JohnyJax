using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public const int FIRST_GAME_SCENE_NUMBER = 1;
    public const int MAIN_MENU_SCENE_NUMBER = 0;
    public static void StartNewGame()
    {
        SceneManager.LoadScene(FIRST_GAME_SCENE_NUMBER);
    }
    public static void LoadMainMenu()
    {
        SceneManager.LoadScene(MAIN_MENU_SCENE_NUMBER);
    }

}
