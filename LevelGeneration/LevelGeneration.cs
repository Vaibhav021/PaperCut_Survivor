using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneration : MonoBehaviour
{
	//element to spawn
	//use both for spawnPoints and elements to spawn
    public GameObject[] element;

    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(0, element.Length);
        Instantiate(element[rand], transform.position, Quaternion.identity);
    }

}//class
