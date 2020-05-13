using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private WaveSystem waveSystem;

    public float minSpawnTime;
    public float maxSpawnTime;

    float minTime;
    float maxTime;

    private float incDiff;

    public GameObject[] enemies;
    public Transform[] spawnPoints;

    private float spawnTime;

    private bool canRecall;
    

    // Start is called before the first frame update
    void Start()
    {
        waveSystem = GameObject.FindGameObjectWithTag("WaveSystem").GetComponent<WaveSystem>();
        canRecall = false;
                

    }

    // Update is called once per frame
    void Update()
    {
        if(waveSystem.wave == true)
        {
            if(canRecall == true)
            {
				//to reset the values on starting of every wave
                RecallValues();                
                canRecall = false;
            }

            spawnTime -= Time.deltaTime;
            incDiff -= Time.deltaTime;

            SpawnEnemy();
            IncreaseDifficulty();

            
        }
        else
        {
            
            canRecall = true;
        }

        RestrictData();

        


    }

    public void RecallValues()
    {
		//Reset wave starting values with adding difficulty

        minTime = minSpawnTime;
        maxTime = maxSpawnTime;

        minSpawnTime -= 1;
        maxSpawnTime -= 1;

        incDiff = waveSystem.waveTime / 3;
    }


    public void SpawnEnemy()
    {
        if(spawnTime <= 0)
        {
            GameObject spawnObject = enemies[Random.Range(0, enemies.Length)];
            Transform spawnPlace = spawnPoints[Random.Range(0, spawnPoints.Length)];

            Instantiate(spawnObject, spawnPlace.position, Quaternion.identity);

            spawnTime = Random.Range(minTime, maxTime);

        }

    }

    public void IncreaseDifficulty()
    {
        if(incDiff <= 0)
        {
            if(minTime > 1)
            {                
                minTime -= 1;
                maxTime -= 1;

            }           
            
            incDiff = waveSystem.waveTime / 3;
        }
    }

    public void RestrictData()
    {
        if (minSpawnTime <= 1)
            minSpawnTime = 0.5f;
        if (maxSpawnTime <= 2)
            maxSpawnTime = 0.5f;


    }
  











}//class
