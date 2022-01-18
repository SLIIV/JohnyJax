using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(EnemyMovement), typeof(EnemyAttack))]
public class EnemyStats : MonoBehaviour
{
    public static OnDeath OnDeath = new OnDeath();
    public EnemyParamenters Stats;
    private int _currentHealth;
    private void Start() 
    {
        _currentHealth = Stats.Health;
    }
    public void TakeDamage()
    {
        if(_currentHealth > 0) _currentHealth--;
        else Kill();

    }
    private void Kill()
    {
        OnDeath.Invoke(Stats);
        GetComponent<Animator>().enabled = false;
        EnemyMovement movement = GetComponent<EnemyMovement>();
        movement.StopMoving();
        movement.enabled = false;
        GetComponent<EnemyAttack>().enabled = false;
        Destroy(gameObject, 5);
    }
}
public class OnDeath : UnityEvent<EnemyParamenters>
{

}
