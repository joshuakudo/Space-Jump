using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollbackground : MonoBehaviour
{
    float scrollspeed = -5f;
    Vector2 startPos;
    void Start()
    {
        startPos = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * scrollspeed, 17);
        transform.position = startPos + Vector2.right * newPos;
    }
}
