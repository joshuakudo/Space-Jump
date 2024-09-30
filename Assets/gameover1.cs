using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover1 : MonoBehaviour
{
    public GameObject gameoverpanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            gameoverpanel.SetActive(true);
        }
    }
    public void restart1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
