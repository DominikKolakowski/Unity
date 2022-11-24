using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie2 : MonoBehaviour
{
    private bool open=false;
    private Vector3 closed;
    private Vector3 opened;
    //otwieranie tych drzwi wygląda jakby było wyciągnięte z minecrafta :)
    void Start()
    {
        closed = transform.position;
        opened = new Vector3(closed.x -3f,closed.y,closed.z+2f);
    }
    void Update()
    {
        if(open)
        {
            transform.rotation = Quaternion.Euler(0,-90,0);
            transform.position = opened;
        }
        else
        {
            transform.rotation = Quaternion.Euler(0,0,0);
            transform.position = closed;
        }
        //drzwi są stale zamknięte lub otwarte, należy dotknąć je jeszcze raz aby zmienić ich stan
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(open)
            {
                open = false;
            }
            else
            {
                open = true;
            }
        }
    }
}
