using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawner : MonoBehaviour
{
    [SerializeField] private float _radius;
    [SerializeField] private float _spawnTime;
    [SerializeField] private GameObject[] _enemies;

    private void Start() 
    {
        StartCoroutine(SpawnEnemyByDelay(_spawnTime));
    }
    private Vector2 GetRandomPointOnRound(Vector2 center, float radius)
    {
        return center + new Vector2(Random.value - 0.5f, Random.value - 0.5f).normalized * radius;
    }
    private Vector3 GetRandomPointOnRound(Vector3 center, float radius)
    {
        return center + new Vector3(Random.value - 0.5f, 0, Random.value - 0.5f).normalized * radius;
    }

    private GameObject GetRandomEnemy()
    {
        int rand = Random.Range(0, _enemies.Length);
        return _enemies[rand];
    } 
    private void CreateEnemy()
    {
        Vector3 center = PlayerController.MovementData.Instance.Player.transform.position;
        Vector3 point = GetRandomPointOnRound(center, _radius);
        GameObject enemy = Instantiate(GetRandomEnemy(), point, Quaternion.identity);
        
    }
    private IEnumerator SpawnEnemyByDelay(float delay)
    {
        while(true) //Заменить эту хуйню на нормальное состояние
        {
            yield return new WaitForSeconds(delay);
            CreateEnemy();
        }
    }
}
