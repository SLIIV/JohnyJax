using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerController
{
    [RequireComponent(typeof(Animator))]
    public class MovementAnimation : MonoBehaviour
    {
        private Animator animator;

        void Start() 
        {
            animator = GetComponent<Animator>();    
            animator.SetBool("With gun", true);
        }
        void Update() 
        {
            animator.SetFloat("Horizontal", Input.HorizontalAxis);
            animator.SetFloat("Vertical", Input.VerticalAxis);
        }
    }
}

