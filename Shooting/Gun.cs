using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private Transform playerPos;    

    [Header("Gun Data")]
    public GameObject bulletPrefab;
    public GameObject bulletParticles;
    public Transform gunPoint;

    [Header("Shoot Time")]
    public float startShootTime;
    private float shootTime;
    

    // Start is called before the first frame update
    void Start()
    {
        playerPos = GetComponentInParent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManagement.isPaused == false)
        {
            GunToMouse();

            //Shooting
            if (Input.GetMouseButton(0))
                Shoot();
            else
                shootTime = 0;
        }

    }


    public void GunToMouse()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = new Vector2(mousePos.x - playerPos.position.x, mousePos.y - playerPos.position.y);
        transform.up = direction;
    }

    public void Shoot()
    {
        if (shootTime <= 0)
        {
            Instantiate(bulletPrefab, gunPoint.position, gunPoint.rotation);
            Instantiate(bulletParticles, gunPoint.position, Quaternion.identity);
            shootTime = startShootTime;
        }
        else
        {
            shootTime -= Time.deltaTime;
        }

    }




















}//class

