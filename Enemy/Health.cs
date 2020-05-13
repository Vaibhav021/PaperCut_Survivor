using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health;
    public GameObject hitAudio;
    public GameObject bloodPatch;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health == 0)
        {
            Instantiate(hitAudio, transform.position, Quaternion.identity);
            Instantiate(bloodPatch, transform.position, Quaternion.identity);
            Instantiate(bullet, transform.position, Quaternion.identity);
            Instantiate(bullet, transform.position, Quaternion.Euler(0,0,90));
            Instantiate(bullet, transform.position, Quaternion.Euler(0,0,180));
            Instantiate(bullet, transform.position, Quaternion.Euler(0,0,270));

            ScoreSystem.killScore += 1;

            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Instantiate(hitAudio, transform.position, Quaternion.identity);
            Instantiate(bloodPatch, transform.position, Quaternion.identity);
            Destroy(gameObject);


        }

    }

    















}//class
