using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    public TextMeshProUGUI killScore;
    public TextMeshProUGUI timeScore;

    private float timeScoreData;

    // Start is called before the first frame update
    void Start()
    {
        SetHighScore();
    }

    // Update is called once per frame
    void Update()
    {        
        
    }

    public void SetHighScore()
    {
        timeScoreData = PlayerPrefs.GetFloat("TimeHighScore");

        killScore.text = "Kill : " + PlayerPrefs.GetInt("KillHighScore");
        timeScore.text = string.Format("Time Survived : {0:#0.00}", timeScoreData);//show time to the 2nd place of the decimal
    }

    public void ResetHighScore()
    {
        PlayerPrefs.SetInt("KillHighScore", 0);
        PlayerPrefs.SetFloat("TimeHighScore", 0f);


        killScore.text = "Kill : 0";
        timeScore.text = "Time Survived : 0.00";
               
    }








}//class
