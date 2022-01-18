using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStates : MonoBehaviour
{
    [SerializeField] private Texture2D _targetCursor;
    private static Texture2D _targetCursorStatic;
    private void Start()
    {
        _targetCursorStatic = _targetCursor;
        SetInGameCursor(); 
    }

    public static void PauseCamera()
    {
        Time.timeScale = 0;
        SetDefaultCursor();
    }
    public static void UnpauseCamera()
    {
        Time.timeScale = 1;
        SetInGameCursor();
    }
    private static void SetDefaultCursor()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }
    private static void SetInGameCursor()
    {
        Cursor.SetCursor(_targetCursorStatic, Vector2.zero, CursorMode.Auto);
    }
}