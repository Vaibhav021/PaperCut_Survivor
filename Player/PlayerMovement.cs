using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    //Move
    public float moveSpeed;

    private Vector2 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManagement.isPaused == false)
        {
            Move();
            Flip();
        }      
        
    }

    public void Move()
    {
        float moveInputX = Input.GetAxis("Horizontal");
        float moveInputY = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(moveInputX * moveSpeed, moveInputY * moveSpeed);

        //Animation
        if (moveInputX != 0 || moveInputY != 0)
            anim.SetBool("isWalking", true);
        else
            anim.SetBool("isWalking", false);


    }

    public void Flip()
    {
		//Player see toward mouse on X-axis
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (mousePos.x > transform.position.x)
        {
            Vector2 temp = transform.localScale;
            temp.x = 1f;
            transform.localScale = temp;
        }

        else if (mousePos.x < transform.position.x)
        {
            Vector2 temp = transform.localScale;
            temp.x = -1f;
            transform.localScale = temp;
        }
        else
        {
            return;
        }


    }















}//class
