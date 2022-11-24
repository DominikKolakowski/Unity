using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie3 : MonoBehaviour
{
    private float speed = 10f;
    public Transform[] points;
    private int i=0;
    private bool reverse=false;
    void Start()
    {
        transform.position = points[0].position;//startujemy zawsze z punktu 1 na liście
    }
    void Update()
    {
        Debug.Log(i);
        if(Vector3.Distance(transform.position, points[i].position) < 0.2f)
        {
            if(reverse)
            {
                i--;
                if(i<0)
                {
                    i=0;
                    reverse=false;
                }
            }
            else
            {
                i++;
                if(i == points.Length)
                {
                    i= points.Length-1;
                    reverse=true;
                }
            }
        }
        transform.position = Vector3.MoveTowards(transform.position,points[i].position, speed * Time.deltaTime);
    }
}
