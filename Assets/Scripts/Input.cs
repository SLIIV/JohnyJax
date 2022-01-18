using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace PlayerController
{
    public class Input : MonoBehaviour
    {
        public const int LEFT_MOUSE_BUTTON = 0; 
        public static float VerticalAxis;
        public static float HorizontalAxis;
        public static UnityEvent OnMouseDown = new UnityEvent();
        public static Vector3 MousePosition;
        public static Vector3 ForwardDirection;
        public static Vector3 SideDirection;
        
        private void Update() 
        {
            VerticalAxis = UnityEngine.Input.GetAxis("Vertical");
            HorizontalAxis = UnityEngine.Input.GetAxis("Horizontal");
            ForwardDirection = MovementData.Instance.Player.transform.forward * VerticalAxis;
            SideDirection = MovementData.Instance.Player.transform.right * HorizontalAxis;

            
            if(UnityEngine.Input.GetMouseButton(LEFT_MOUSE_BUTTON))
            {
                OnMouseDown.Invoke();
            }

            Ray ray = Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition);
            if(Physics.Raycast(ray, out RaycastHit raycastHit))
            {
                MousePosition = raycastHit.point;
            }
        }
    }
}

