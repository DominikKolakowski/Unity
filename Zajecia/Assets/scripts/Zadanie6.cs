using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie6 : MonoBehaviour
{
    Transform target;
    public GameObject Target;
    float smoothTime = 3f;
    float yVelocity = 0.0f;

    void Start()
    {

    }

   
    void Update()
    {
        float newPositionx = Mathf.SmoothDamp(transform.position.x, Target.transform.position.x, ref yVelocity, smoothTime);
        transform.position = new Vector3(newPositionx, transform.position.y, transform.position.z);
    }
}