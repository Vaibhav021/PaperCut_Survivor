using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EN_Bullet : MonoBehaviour
{
    public float bulletSpeed;

    public float deathTime;

    public GameObject deadPar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * bulletSpeed * Time.deltaTime);

        Invoke("BulletDeath", deathTime);
    }

    public void OnTriggerEnter2D(Collider2D col)
    {

        if(col.gameObject.tag == "Player")
        {
            PlayerHealth playerHealth = col.gameObject.GetComponent<PlayerHealth>();
            playerHealth.health -= 5;

            BulletDeath();
        }

    }

    public void BulletDeath()
    {
        Instantiate(deadPar, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
















}//class
