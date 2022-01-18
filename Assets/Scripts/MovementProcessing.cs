using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerController
{
    public class MovementProcessing : MonoBehaviour
    {
        private void FixedUpdate() 
        {
            Move();
            Rotate();
        }
        private void Move()
        {
            if(Input.HorizontalAxis != 0 || Input.VerticalAxis !=0)
            {
                MovementData.Instance.Player.transform.position += (Input.SideDirection + Input.ForwardDirection).normalized * MovementData.Instance.Speed * Time.fixedDeltaTime;
            }
        }
        private void Rotate()
        {
            Vector3 deltaMousepos = Input.MousePosition - MovementData.Instance.Player.transform.position;
            float rotationY = Mathf.Atan2(deltaMousepos.z, deltaMousepos.x) * Mathf.Rad2Deg;
            MovementData.Instance.Player.transform.rotation = Quaternion.Euler(0, -rotationY + MovementData.Instance.MouseRotationOffset, 0);
        }
        
    }
}

