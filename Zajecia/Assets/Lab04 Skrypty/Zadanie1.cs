using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public float delay = 3.0f;
    public int iloscKostek = 1;
    int objectCounter = 0;

    public Material kolor1;
    public Material kolor2;
    public Material kolor3;
    public Material kolor4;
    public Material kolor5;
    public GameObject block;

    void Start()
    {

        Vector3 Max = GetComponent<MeshRenderer>().bounds.max;
        Vector3 Min = GetComponent<MeshRenderer>().bounds.min;
        List<int> pozycje_x = new List<int>(Enumerable.Range(Convert.ToInt32(Min.x), Convert.ToInt32(Max.x)).OrderBy(x => Guid.NewGuid()).Take(10));
        List<int> pozycje_z = new List<int>(Enumerable.Range(Convert.ToInt32(Min.z), Convert.ToInt32(Max.z)).OrderBy(x => Guid.NewGuid()).Take(10));

        for (int i = 0; i < iloscKostek; i++)
        {
            this.positions.Add(new Vector3(pozycje_x[i], Max.y + 5, pozycje_z[i]));
        }
        foreach (Vector3 elem in positions)
        {
            Debug.Log(elem);
        }
        // uruchamiamy coroutine
        StartCoroutine(GenerujObiekt());
    }

    void Update()
    {

    }

    IEnumerator GenerujObiekt()
    {
        List<Material> kolory = new List<Material>() { kolor1, kolor2, kolor3, kolor4, kolor5 };
        Debug.Log("wywolano coroutine");
        foreach (Vector3 pos in positions)
        {
            block.GetComponent<MeshRenderer>().material = kolory[UnityEngine.Random.Range(0, 5)];
            Instantiate(this.block, this.positions.ElementAt(this.objectCounter++), Quaternion.identity);
            yield return new WaitForSeconds(this.delay);
        }
        // zatrzymujemy coroutine
        StopCoroutine(GenerujObiekt());
    }
}
