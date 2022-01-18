using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public const int MAX_HEALTH = 3;
    public static int CurrentHealth;
    public void Start() 
    {
        CurrentHealth = MAX_HEALTH;
        EnemyAttack.OnHitted.AddListener(() => GetDamage());
    }
    public void GetDamage()
    {
        if(CurrentHealth > 0)
            CurrentHealth--;
        if(CurrentHealth == 0)
            GameState.OnLose.Invoke();
    }
}
