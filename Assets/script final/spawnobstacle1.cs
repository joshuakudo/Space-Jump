using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class spawnobstacle1 : MonoBehaviour
{
    public GameObject  obstacle1;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timebtwspawn;
    private float spawntime;
    void Update()
    {
       if (Time.time > spawntime)
        {
            spawn();
            spawntime = Time.time + timebtwspawn;
        }
    }

     void spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(obstacle1, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
        
    }
}
