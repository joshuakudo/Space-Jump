using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
   
    public float speed;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);  
    }

    
}