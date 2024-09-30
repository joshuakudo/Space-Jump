using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopbackground : MonoBehaviour
{
    public float bgspeed;
    public Renderer bgrenderer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bgrenderer.material.mainTextureOffset += new Vector2
            (bgspeed * Time.deltaTime, 0f);
    }
}
