using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramovement2 : MonoBehaviour
{
    public float cameraspeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, -cameraspeed * Time.deltaTime, 0);
    }
}
