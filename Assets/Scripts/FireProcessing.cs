using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WeaponController
{
    public class FireProcessing : MonoBehaviour
    {
        private bool _isReadyForFire;
        void Start()
        {
            PlayerController.Input.OnMouseDown.AddListener(() => CreateBullet());
            _isReadyForFire = true;
        }

        private void CreateBullet()
        {
            if(_isReadyForFire)
            {
                Instantiate(FireData.Instance.BulletPrefab, FireData.Instance.BulletSource.transform.position, Quaternion.identity);
                _isReadyForFire = false;
                StartCoroutine(Reload());
            }

        }
        private void OnDestroy() 
        {
            PlayerController.Input.OnMouseDown.RemoveListener(() => CreateBullet());
        }
        private IEnumerator Reload()
        {
            yield return new WaitForSeconds(WeaponController.FireData.Instance.WeaponObject.Parameters.RateOfFire);
            _isReadyForFire = true;
        }
    }
}

