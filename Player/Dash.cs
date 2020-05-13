using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    private Rigidbody2D rb;
    private PlayerMovement moveScript;

    private float dashAxisX = 1f, dashAxisY;
    private float moveX, moveY;

    private float dashTime;

    public float dashSpeed;
    public float startDashTime;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveScript = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dashTime <= 0)
        {
            moveScript.enabled = true;
            dashTime = 0;
        }
        else
        {
            StartDashing();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            dashTime = startDashTime;
        }
        
        //Get Axis Data
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");

		//Saving Axis Data
        if (moveX != 0 || moveY != 0)
        {
            dashAxisX = moveX;
            dashAxisY = moveY;
        }

    }


    public void StartDashing()
    {
        dashTime -= Time.deltaTime;
        moveScript.enabled = false;

        rb.velocity = new Vector2(dashAxisX * dashSpeed, dashAxisY * dashSpeed);


    }















}//class
