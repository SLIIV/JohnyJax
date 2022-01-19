using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(EnemiesAnimation))]
public class EnemyAttack : MonoBehaviour
{
    public static UnityEvent OnAttack = new UnityEvent();
    public static UnityEvent OnHitted = new UnityEvent();
    [SerializeField] private float _attackDelay;
    [SerializeField] private float _reloadTime;
    [SerializeField] private float _attackDistance;
    [SerializeField] private float _attackRadius;
    private EnemiesAnimation _animations;
    private bool _isReload;
    private int _playerMask = 1 << 8;

    private void Start() 
    {
        _isReload = false;
        _animations = GetComponent<EnemiesAnimation>();
    }
    void Update() 
    {
        Attack();
    }

    private bool PlayerCastState(float radius, float distance)
    {
        if(Physics.SphereCast(transform.position, radius, transform.forward, out RaycastHit hit, distance, _playerMask))
        { 
            return true;
                
        }
        return false;
    }
    private void Attack()
    {
        if(PlayerCastState(_attackRadius, _attackDistance))
        {
            if(!_isReload)
            {
                _animations.ActivateAttackAnimation();
                StartCoroutine(AttackWithDelay(_attackDelay, _reloadTime));
                _isReload = true;
            }
        }
    }

    private IEnumerator AttackWithDelay(float delay, float reloadTime)
    {
        yield return new WaitForSeconds(delay);
        if(PlayerCastState(_attackRadius, _attackDistance))
        {
            OnHitted.Invoke();
        }
        StartCoroutine(ReloadAttack(reloadTime));
    }
    private IEnumerator ReloadAttack(float reloadTime)
    {
        yield return new WaitForSeconds(reloadTime);
        _isReload = false;
    }
}
