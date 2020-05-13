using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    public float maxX;
    public float maxY;

    float minX;
    float minY;

    // Start is called before the first frame update
    void Start()
    {
        minX = -maxX;    
        minY = -maxY;

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 temp = transform.position;

        //X
        if (temp.x > maxX)
            temp.x = maxX;
        else if (temp.x < minX)
            temp.x = minX;

        //Y
        else if (temp.y > maxY)
            temp.y = maxY;
        else if (temp.y < minY)
            temp.y = minY;

        transform.position = temp;




    }















}//class
