using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthAddUps : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 15f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            playerHealth.health += 10;

            Destroy(gameObject);
        }

    }














}//class
