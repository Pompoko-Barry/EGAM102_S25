using UnityEngine;

public class Swing : MonoBehaviour
{

    private Animator swingAnimator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        swingAnimator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Swings are going");

            swingAnimator.SetTrigger("Input");
        }
    }
}
