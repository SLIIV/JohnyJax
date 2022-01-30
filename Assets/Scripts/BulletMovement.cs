using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class BulletMovement : MonoBehaviour
{
    private Transform _transform;
    private float _speed;
    private Rigidbody _rb;

    private void Start()
    {
        Init();
         _rb.AddForce(transform.forward * _speed);
        
    }

    private void Init()
    {
        _transform = GetComponent<Transform>();
        _speed = WeaponController.FireData.Instance.BulletSpeed;
        Vector3 deltaMousepos = PlayerController.Input.MousePosition - PlayerController.MovementData.Instance.Player.transform.position;
        float rotationY = Mathf.Atan2(deltaMousepos.z, deltaMousepos.x) * Mathf.Rad2Deg;
        _transform.rotation = Quaternion.Euler(0, -rotationY + 90, 0);
        Destroy(gameObject, 2f);
        _rb = GetComponent<Rigidbody>();
    }
    
    private void OnCollisionEnter(Collision other) 
    {
        EnemyStats enemy;
        if(enemy = other.collider.gameObject.GetComponentInParent<EnemyStats>())
        {
            enemy.TakeDamage();
        }
        Destroy(gameObject);
    }

}
