using UnityEngine;

public class TriggerAnimationOnCollision : MonoBehaviour
{
    private Animator animator;  // Reference to the Animator component


    void Start()
    {
        // Get the Animator component attached to the GameObject
        animator = GetComponent<Animator>();
    }

    // This function will be called when another object enters the trigger collider
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object that collided with this one has the "Player" tag
        if (other.CompareTag("Player"))
        {
            Debug.Log("Script for animator has correctly read the player collision.");
            // Trigger the animation using the "Start" trigger parameter in the Animator
            if (animator != null)
            {
                animator.SetTrigger("Start");
            }
        }
    }
}