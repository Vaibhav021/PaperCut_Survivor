using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    public TextMeshProUGUI killScoreText;
    public TextMeshProUGUI timerText;

    public static int killScore;

    private float timer;


    // Start is called before the first frame update
    void Start()
    {
        killScore = 0;
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(!GameOver.gameOver)
            timer += Time.deltaTime;

        SetScore();        

    }

    public void SetScore()
    {
        killScoreText.text = "Kills : " + killScore;
        timerText.text = string.Format("Time : {0:#0.00}", timer);


        //Set HighScore
		//Saving through playerPref
        if (killScore > PlayerPrefs.GetInt("KillHighScore", 0))
            PlayerPrefs.SetInt("KillHighScore", killScore);

        if (timer > PlayerPrefs.GetFloat("TimeHighScore", 0f))
            PlayerPrefs.SetFloat("TimeHighScore", timer);

    }













}//class
