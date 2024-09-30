using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float rotatespeed;
    public float rspeed;
    private Rigidbody2D rb;
    private Vector2 screenbounds;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-rspeed, 0);
        screenbounds = Camera.main.ScreenToWorldPoint(new Vector3(2 * Screen.width, Screen.height, Camera.main.transform.position.z));   
    }
     
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotatespeed);
        if (transform.position.x < screenbounds.x )
        {
            Destroy(this.gameObject);
        }
    }
}
