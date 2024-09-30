using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quit : MonoBehaviour
{
    private Button quitbutton;
    void Start()
    {
        quitbutton = GetComponent<Button>();
        quitbutton.onClick.AddListener(QuitGame);
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();  
    }
}
