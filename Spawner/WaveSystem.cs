using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSystem : MonoBehaviour
{
    [HideInInspector]
    public Animator anim;
    private bool playAnim = false;
    private bool canPlayAnim = true;

    public bool wave = false;

    public float waveTime = 30f;
    public float waveLessTime = 10f;

    float startWaveTime;
    float stopWaveTime;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        startWaveTime = waveTime;
        stopWaveTime = 7f;
    }

    // Update is called once per frame
    void Update()
    {
        if(wave == true)
        {
            stopWaveTime = waveLessTime;
            StartWave();
        }
        if(wave == false)
        {
            startWaveTime = waveTime;
            StopWave();
        }


        //Animation
        if(playAnim == true)
        {
            anim.SetTrigger("WaveText");
            playAnim = false;
        }



    }

    public void StartWave()
    {
        startWaveTime -= Time.deltaTime;

        canPlayAnim = true;

        if (startWaveTime > 0)
            wave = true;
        else
        {
            HealthSpawner.addUp = true;
            wave = false;
        }


    }

    public void StopWave()
    {
        stopWaveTime -= Time.deltaTime;

        if (stopWaveTime <= 3f && canPlayAnim == true)
        {
            playAnim = true;
            canPlayAnim = false;
        }

        if (stopWaveTime > 0)
            wave = false;
        else
            wave = true;

    }



















}//class
