using UnityEngine;

public class AnimationFlappies : MonoBehaviour
{
    public Animator animator; //to reference the animator component 
   
  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Play");
        }
    }
}
