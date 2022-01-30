using UnityEngine;
using UnityEngine.Events;

public class HandsController : MonoBehaviour
{
    private WeaponController.WeaponObject _weapon;

    private void Start() 
    {
        SetDefaultWeapon();
    }

    private void SetDefaultWeapon()
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
        if(collider.GetComponent<AmmoBox>())
        {
            AmmoBox.AddAmmo();
            Destroy(collider.gameObject);
        }
    }
}
