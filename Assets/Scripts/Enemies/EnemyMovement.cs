using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(EnemyStats))]
[RequireComponent(typeof(NavMeshAgent))]
public class EnemyMovement : MonoBehaviour
{
    private NavMeshAgent _enemyNavMesh;
    private EnemyStats _enemyStats;
    private Transform _player;
    
    private void Start() 
    {
        Init();
    }
    private void Init()
    {
        _enemyStats = GetComponent<EnemyStats>();
        _enemyNavMesh = GetComponent<NavMeshAgent>();
        _enemyNavMesh.speed = _enemyStats.Stats.Speed;
        transform.position += Vector3.up * 0.35f;
        if(Physics.RaycastAll(transform.position, Vector3.down, Mathf.Infinity).Length == 0)
        {
            Destroy(gameObject);
        }
        StartCoroutine(SetDestination(0.5f));
        
        
    }
    private void Move()
    {
        _enemyNavMesh.destination = EnemyNavigation.GetTarget().position;
    }
    public void StopMoving()
    {
        _enemyNavMesh.isStopped = true;
    }
    private IEnumerator SetDestination(float delay)
    {
        while(true) // заменить бесконечный цикл на условный
        {
            yield return new WaitForSeconds(delay);
            Move();
        }
        
    }

}
