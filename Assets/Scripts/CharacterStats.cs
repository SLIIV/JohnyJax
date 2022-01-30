using UnityEngine;
using UnityEngine.Events;

public class CharacterStats : MonoBehaviour
{
    public static UnityEvent OnAmmoChanged = new UnityEvent();
    public const int MAX_HEALTH = 3;
    public static int CurrentHealth;
    public const int START_AMMO = 50;
    public static int CurrentAmmo;

    public void Start() 
    {
        CurrentHealth = MAX_HEALTH;
        CurrentAmmo = START_AMMO;
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
