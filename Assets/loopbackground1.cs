using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopbackground1 : MonoBehaviour
{
    public float bgspeed1;
    public Renderer bgrenderer1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bgrenderer1.material.mainTextureOffset += new Vector2
             (0f, -bgspeed1 * Time.deltaTime);
    }
}
