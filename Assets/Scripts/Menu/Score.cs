using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text _score;

    private void Start() 
    {
        EnemyStats.OnDeath.AddListener((stats) => AddScore(stats.Reward));
    }
    public void AddScore(int count)
    {
        int currentScore = int.Parse(_score.text);
        currentScore += count;
        _score.text = currentScore.ToString();
    }
    private void OnDisable()
    {
        EnemyStats.OnDeath.RemoveListener((stats) => AddScore(stats.Reward));
    }
}
