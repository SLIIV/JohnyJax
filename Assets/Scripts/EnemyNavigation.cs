using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavigation : MonoBehaviour
{
    private static Transform _player;
    private static Vector3 _priviusPosition;
    private void Start()
    {
        _player = FindObjectOfType<PlayerController.Input>().GetComponent<Transform>();
    }
    public static Transform GetTarget()
    {
        return _player;
    }
}
