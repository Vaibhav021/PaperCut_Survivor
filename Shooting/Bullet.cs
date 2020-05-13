using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;

    public float deathTime;

    public GameObject deathPar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * bulletSpeed * Time.deltaTime);

        Invoke("SelfDestruct", deathTime);
        
    }
    
    public void SelfDestruct()
    {
        Instantiate(deathPar, transform.position, Quaternion.identity);
        Destroy(gameObject);

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Player")
        {
            Instantiate(deathPar, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Enemy")
        {
            Health en_Health = collision.gameObject.GetComponent<Health>();
            en_Health.health -= 1f;
        }

    }












}//class
