using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene2button : MonoBehaviour
{
    public GameObject buttonforscene2;
    void Start()
    {
        buttonforscene2.SetActive(false);
        StartCoroutine(waiting());
    }

    private IEnumerator waiting()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            yield return new WaitForSeconds(100);
            buttonforscene2.SetActive(true);
            
        }
    }
}
