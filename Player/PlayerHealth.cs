using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    private float maxHealth;

    public GameObject bloodPatch;


    // Start is called before the first frame update
    void Awake()
    {
        HealthBar.health = health;
        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerDeath();
        HealthBar.health = health;

        if (health > maxHealth)
            health = maxHealth;

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            health -= 10;            
            print("health = " + health);
        }
    }

    public void PlayerDeath()
    {
        if(health <= 0)
        {
            Instantiate(bloodPatch, transform.position, Quaternion.identity);
            GameOver.gameOver = true;
            Destroy(gameObject);
        }
    }






















}//class
