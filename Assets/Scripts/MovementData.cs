﻿using UnityEngine;

namespace PlayerController
{
    public class MovementData : MonoBehaviour
    {
        public static MovementData Instance;
        void Awake()
        {
            if (Instance) Destroy(gameObject);
            else Instance = this;
        }
        public GameObject Player { get {return _player; } }
        public float Speed { get { return _speed; } }
        public float MouseRotationOffset { get {return _mouseRotationOffset; } }
        [SerializeField] private GameObject _player;
        [SerializeField] private float _speed;
        [SerializeField] private float _mouseRotationOffset;
    }
}