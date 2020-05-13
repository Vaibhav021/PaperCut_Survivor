using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSpawner : MonoBehaviour
{
    public static bool addUp;

    public GameObject healthAddup;    

    public float maxY, maxX;
    private float minX, minY;


    // Start is called before the first frame update
    void Start()
    {
        addUp = false;

        minX = -maxX;
        minY = -maxY;
                
    }

    // Update is called once per frame
    void Update()
    {
        if(addUp)
        {
            for(int i = 0; i < 4; i++ )
            {
                Vector2 spawnPoint = new Vector2(Random.Range(maxX, minX), Random.Range(maxY, minY));

                Instantiate(healthAddup, spawnPoint, Quaternion.identity);

            }

            addUp = false;
        }
        
    }





}//class
