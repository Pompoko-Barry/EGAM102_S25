using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ScreenWrap : MonoBehaviour
{
    public float rightScreenBoundary = 9.5f;
    public float leftScreenBoundary = -9.5f;
    public float topScreenBoundary = 5.5f;
    public float bottomScreenBoundary = -5.5f;

    public float wrapTop = 4.5f;
    public float wrapBottom = -4.5f;
    public float wrapLeft = 8.5f;
    public float wrapRight = -8.5f;

    void Update()
    {
        if (transform.position.x >= rightScreenBoundary)
        {
            transform.position = new Vector3(wrapRight, transform.position.y, transform.position.z);
        }
        if (transform.position.x <= leftScreenBoundary)
        {
            transform.position = new Vector3(wrapLeft, transform.position.y, transform.position.z);
        }
    //     if (transform.position.y >= topScreenBoundary)
    //     {
    //         transform.position = new Vector3(transform.position.x, wrapBottom, transform.position.z);
    //     }
    //     if (transform.position.y <= bottomScreenBoundary)
    //     {
    //         transform.position = new Vector3(transform.position.x, wrapTop, transform.position.z);
    //     }
    }
}