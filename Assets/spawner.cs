using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject asteroid;
    public float respawntime = 1.0f;
    private Vector2 screenbounds;
    void Start()
    {
        screenbounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(wave());

    }


private void spawnenemy ()
    {
        GameObject a = Instantiate(asteroid) as GameObject;
        a.transform.position = new Vector2(screenbounds.x * -2, Random.Range(-screenbounds.y, maxInclusive: screenbounds.y));
    }
    IEnumerator wave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawntime);
            spawnenemy();
        }
    }
    
}
