using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie3 : MonoBehaviour
{
    public float speed = 1.0f;
    public Rigidbody rb;
    Vector3 start = new Vector3(0f, 1f, 0f);
    Vector3 start2 = new Vector3(10f, 1f, 0f);
    Vector3 start3 = new Vector3(10f, 1f, 10f);
    Vector3 start4 = new Vector3(0f, 1f, 10f);

    void Start()
    {
        transform.position = start;
        rb.AddForce(Vector3.back * speed, ForceMode.Impulse);
    }
    void FixedUpdate()
    {
        if (transform.position == start2)
        {
            transform.position = start2;
            transform.eulerAngles = new Vector3(0f, 270f, 0f);
            rb.AddForce(Vector3.left * speed, ForceMode.Impulse);
            rb.AddForce(Vector3.forward * speed, ForceMode.Impulse);
        }
        if (transform.position.z >= start3.z && transform.position.x >= start3.x)
        {
            transform.position = start3;
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
            rb.AddForce(Vector3.back * speed, ForceMode.Impulse);
            rb.AddForce(Vector3.left * speed, ForceMode.Impulse);
        }
        if (transform.position.x <= start4.x && transform.position.z >= start4.z)
        {
            transform.position = start4;
            transform.eulerAngles = new Vector3(0f, 90f, 0f);
            rb.AddForce(Vector3.right * speed, ForceMode.Impulse);
            rb.AddForce(Vector3.back * speed, ForceMode.Impulse);
        }
        if (transform.position == start)
        {
            transform.position = start;
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
            rb.AddForce(Vector3.forward * speed, ForceMode.Impulse);
            rb.AddForce(Vector3.right * speed, ForceMode.Impulse);
        }
    }
}