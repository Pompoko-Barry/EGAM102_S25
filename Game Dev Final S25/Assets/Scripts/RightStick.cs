using UnityEngine;

public class RightStick : MonoBehaviour
{
    private Rigidbody2D rb;
    private FixedJoint2D fixedJoint;
    private bool isStuck = false;
    private Rigidbody2D collidedObjectRb;

    public string gameWorldTag = "Game World"; //the tag of objects it will stick to

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))  //check for this input to toggle sticking and un sticking 
        {
            if (isStuck)
            {
                UnstickObject();
            }

            else if (collidedObjectRb != null) //only stick if collided with another object
            {
                StickObject();
            }

        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(gameWorldTag))
        {
            collidedObjectRb = collision.gameObject.GetComponent<Rigidbody2D>();

            ////if havent already stuck to something, will attempt to stick
            //if (!isStuck && collidedObjectRb != null)
            //{
            //    StickObject();
            //}
        }
    }

    private void StickObject()
    {
        if (fixedJoint == null)
        {
            fixedJoint = gameObject.AddComponent<FixedJoint2D>();
        }

        //connect to the colliding object's rigid body
        fixedJoint.connectedBody = collidedObjectRb;

        //set the joint's break force to prevent it from breaking under certain conditions
        fixedJoint.breakForce = 10000f;

        //set isStuck flag to true
        isStuck = true;
    }

    private void UnstickObject()
    {
        //if a joint exists, destroy it to unstick the objects
        if (fixedJoint != null)
        {
            Destroy(fixedJoint);
        }

        //reset the isStuck flag
        isStuck = false;
        collidedObjectRb = null;
    }
}