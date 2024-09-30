using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclespawner : MonoBehaviour
{
    public Transform[] spawnpoints;
    public GameObject[] obstacle;
    int randomspawnpoint, randomobstacle;
    public static bool spawnallowed;

    void Start()
    {
        spawnallowed = true;
        InvokeRepeating("Spawnanobstacle", 0f, 5f);
    }

    void Spawnanobstacle ()
    {
        if (spawnallowed)
        {
            randomspawnpoint = Random.Range(0, spawnpoints.Length);
            randomobstacle = Random.Range(0, obstacle.Length);
            Instantiate(obstacle[randomobstacle], spawnpoints[randomspawnpoint].position, Quaternion.identity);

        }
    }
    
}
