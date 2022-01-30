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
    private Vector3 GetRandomPointOnRound(float radius)
    {
       Vector2 pointOnCircle = PlayerController.MovementData.GetRandomPointInCircle();
       Vector3 pointOnRound = new Vector3(pointOnCircle.x, 0, pointOnCircle.y) * radius;
       return pointOnRound;
    }

    private GameObject GetRandomEnemy() //заменить название метода
    {
        int rand = Random.Range(0, _enemies.Length);
        return _enemies[rand];
    } 
    private void CreateEnemy()
    {
        Vector3 center = PlayerController.MovementData.Instance.Player.transform.position;
        Vector3 point =  center + GetRandomPointOnRound(_radius);
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
