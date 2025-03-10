using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DestroyItem : MonoBehaviour

{
    private GoalManager goalManager;
//     public AudioSource sfxSource;
//    public AudioClip destroySound;


    void Start ()
    {
        goalManager = FindObjectOfType<GoalManager>();
    }

   void OnCollisionEnter2D(Collision2D collision)
   {
    if (collision.gameObject.CompareTag("Goal"))
    {
        Destroy(collision.gameObject);
        // sfxSource.clip = (destroySound);
        //    sfxSource.Play();

        if (goalManager != null)
        {
            goalManager.GoalDestroyed();
        }
    }
   }
}
