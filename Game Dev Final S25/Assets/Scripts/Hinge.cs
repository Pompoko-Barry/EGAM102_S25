using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Hinge : MonoBehaviour
{

    public HingeJoint2D hinge;
    public float motorSpeed = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            JointMotor2D tempMotor = hinge.motor;

            tempMotor.motorSpeed = motorSpeed;

            hinge.motor = tempMotor;
        }

        else if (Input.GetKeyUp(KeyCode.Space))
            {
            JointMotor2D tempMotor = hinge.motor;

            tempMotor.motorSpeed = -motorSpeed;

            hinge.motor = tempMotor;
        }
        
    }
}
