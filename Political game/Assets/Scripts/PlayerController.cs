using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] Animator animator;

    Vector2 movement;

    private void Update() {
        movement.x= Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    private void FixedUpdate() {
        
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
