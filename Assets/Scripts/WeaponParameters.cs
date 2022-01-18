using UnityEngine;

namespace WeaponController
{
    [CreateAssetMenu(fileName = "Weapon", menuName = "ScriptableObjects/WeaponPatameters", order = 0)]
    public class WeaponParameters : ScriptableObject
    {
        public string Name { get { return _name; } }
        public int CartrigesInTheStore { get { return _cartrigesInTheStore; } }
        public float RateOfFire { get { return _rateOfFire; } }
        public float Damage { get {return _damage; } }
        public float BulletSpeed { get { return _bulletSpeed; } }
        [SerializeField] private string _name;
        [SerializeField] private int _cartrigesInTheStore;
        [SerializeField] private float _rateOfFire;
        [SerializeField] private float _damage;
        [SerializeField] private float _bulletSpeed;
        
    }
}

