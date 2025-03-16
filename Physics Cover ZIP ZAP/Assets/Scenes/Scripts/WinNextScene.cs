using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class WinNextScene : MonoBehaviour
{
    public float delayTime = 3f; //time to delay before loading next scene

    private bool isColliding = false;

    private float collisionTime = 0f;


    //private Animator CircleSizeIncrease;

    void Start()
    {
       // CircleSizeIncrease = GetComponent<Animator>();
    }
  
    // Update is called once per frame
    void Update()
    {
        if (isColliding)
        { 
            collisionTime += Time.deltaTime;
            if (collisionTime >= delayTime)
         {
            StartCoroutine(LoadNextSceneAfterDelay());
            isColliding = false; //so that it only happens once
            //collisionTime = 0f;
         }
        }
        
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isColliding = true;
            Debug.Log("Player is colliding with win circle.");
        }

        // if (CircleSizeIncrease != null)
        // {
        //     CircleSizeIncrease.SetTrigger("Start");
        //     Debug.Log("Start trigger is triggered!");
        // }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isColliding = false; //to stop timer is Player tagged exits collider zone
          //  collisionTime = 0f; //to reset timer
        }
    }


    IEnumerator LoadNextSceneAfterDelay()
    {

        // if (CircleSizeIncrease != null)
        // {
        //     CircleSizeIncrease.SetTrigger("Start");
        //     Debug.Log("Start trigger is triggered!");
        // }
        yield return new WaitForSeconds(delayTime);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
