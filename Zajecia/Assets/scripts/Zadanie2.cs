using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie2 : MonoBehaviour
{
    public float speed = 15.0f;
    public Rigidbody rb;
    Vector3 start = new Vector3(0f, 1f, 0f);
    Vector3 stop = new Vector3(10f, 1f, 0f);

    void Start()
    {
        rb.AddForce(Vector3.right * speed, ForceMode.Impulse);
    }
    void FixedUpdate()
    {
        if (transform.position.x >= stop.x)
        {
            transform.position = stop;
            rb.AddForce(Vector3.left * speed, ForceMode.Impulse);
        }
        if (transform.position.x <= start.x)
        {
            transform.position = start;
            rb.AddForce(Vector3.right * speed, ForceMode.Impulse);
        }
    }
}