using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoretext;
    private float scores;
    public static int totalscore;
    public Text hiiiscore;
    void Start()
    {
        hiiiscore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            scores += 1 * Time.deltaTime;
            scoretext.text = ((int)scores).ToString();
            totalscore = ((int)(scores));
        }
        if (totalscore > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", totalscore);
            hiiiscore.text = totalscore.ToString();
        }
    }
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        hiiiscore.text = "0";
    }
}
    

