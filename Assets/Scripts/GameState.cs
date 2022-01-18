using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameState : MonoBehaviour
{
    public static bool IsPause;
    public static bool isLose;
    public static UnityEvent OnLose = new UnityEvent();
    public static UnityEvent OnPause = new UnityEvent();
    
    private void Start() 
    {
        IsPause = false;
        isLose = false;
    }

}
