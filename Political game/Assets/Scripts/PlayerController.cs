using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] Animator animator;
    [SerializeField] private Canvas choiceMaster;
    [SerializeField] private speachEvent speachEvent;

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

    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.layer == 6){
            
            choiceMaster.gameObject.SetActive(true);   
        
        }
        else if (other.gameObject.layer == 7){
            SceneManager.LoadScene("building 2");
        }
        if (other.gameObject.layer == 8){
            speachEvent.triggerEvent();
        }
    }

}
