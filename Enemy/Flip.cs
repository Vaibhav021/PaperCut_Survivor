using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    private Transform playerPos;

    // Start is called before the first frame update
    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 temp = transform.localScale;

        if (playerPos.position.x > transform.position.x)
            temp.x = 1f;
        else if (playerPos.position.x < transform.position.x)
            temp.x = -1f;

        transform.localScale = temp;


    }







}//class
