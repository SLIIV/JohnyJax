using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace WeaponController
{
    [RequireComponent(typeof(FireProcessing))]
    public class FireData : MonoBehaviour
    {
        public static FireData Instance;
        void Awake()
        {
            if (Instance) Destroy(gameObject);
            else Instance = this;
        }

        public GameObject BulletPrefab { get { return _bulletPrefab; } }
        public WeaponObject WeaponObject { get; set; }
        public BulletSource BulletSource { get; set; }
        public float BulletSpeed { get {return _bulletSpeed; } }
        [SerializeField] private GameObject _bulletPrefab;
        [SerializeField] private float _bulletSpeed;
    }
}

