using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show : MonoBehaviour
{
    public GameObject hidden;

    void OnTriggerEnter2D(Collider2D other)
    {
     if (other.gameObject.CompareTag("Player"))
     {
        print("triger");
        hidden.gameObject.SetActive(true);
     }
    }
}
