using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie5 : MonoBehaviour
{
    public GameObject Cube;
    private int i = 0;
    void Start()
    {
        while (i < 10)
        {
            Vector3 pozycja = new Vector3(Random.Range(-49, 49), 1, Random.Range(-49, 49));
            Collider[] zderzenie = Physics.OverlapSphere(pozycja, 1);
            if (zderzenie.Length == 0)
            {
                Instantiate(Cube, pozycja, Quaternion.identity);
                i++;
            }
        }
    }
}