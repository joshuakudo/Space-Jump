using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score1 : MonoBehaviour
{
    public Text scoretext1;
    private float scores1 = 0f;
    private int scores2;
    private int TotalScore;
    public Text hiscore;
    
    void Start()
    {
        hiscore.text = PlayerPrefs.GetInt("HighScore", 0).ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            scores1 += (2 * Time.deltaTime) ;
            scores2 = ((((int)scores1) + Score.totalscore)) ;

            scoretext1.text = ((((int)scores1)+Score.totalscore).ToString()); 
        }
        if (scores2 > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", scores2);
            hiscore.text = scores2.ToString();
        }
    }
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        hiscore.text = "0";
    }
}
