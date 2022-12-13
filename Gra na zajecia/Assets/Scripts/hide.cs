using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide : MonoBehaviour
{
    public GameObject notHidden;

    private void OnTriggerEnter2D(Collider2D other)
    {
     if (other.gameObject.CompareTag("Player"))
     {
         notHidden.gameObject.SetActive(false);
     }
    }
}