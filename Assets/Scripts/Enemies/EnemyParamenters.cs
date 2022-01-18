using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "ScriptableObjects/EnemyPatameters", order = 0)]
public class EnemyParamenters : ScriptableObject
{
    [SerializeField] private int _health;
    [SerializeField] private float _speed;
    [SerializeField] private int _reward;

    public int Health { get { return _health; } }
    public float Speed {get {return _health; } }
    public int Reward {get {return _reward; } }
}
