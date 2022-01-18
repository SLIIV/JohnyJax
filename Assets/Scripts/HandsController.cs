using UnityEngine;

public class HandsController : MonoBehaviour
{
    private WeaponController.WeaponObject _weapon;
    private void Start() 
    {
        WeaponController.WeaponObject weapon;
        if(weapon = gameObject.GetComponentInChildren<WeaponController.WeaponObject>())
        {
            TakeGun(weapon);
        }
    }
    private void TakeGun(WeaponController.WeaponObject weaponToTake)
    {
        WeaponController.FireData.Instance.WeaponObject = weaponToTake;
        WeaponController.FireData.Instance.BulletSource = weaponToTake.GetComponentInChildren<BulletSource>();
    }

    private void OnTriggerEnter(Collider collider) 
    {
        if(collider.TryGetComponent<WeaponController.WeaponObject>(out _weapon))
        {
            TakeGun(_weapon);
        }
    }
}
