using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _player;
    private Vector3 _delta;
    private void Start() 
    {
        _delta = Camera.main.transform.position - _player.transform.position;
    }
    private void Update() 
    {
        Camera.main.transform.position = _player.transform.position + _delta;
    }
}
