using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie5 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Przeszkoda"))
        {
            Debug.Log("Doszlo do kolizji");
        }
    }
}
