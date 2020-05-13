using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Image healthBar;

    private float maxHealth;

    public static float health;

    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Image>();

        maxHealth = health;

    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = health / maxHealth;


    }










}//class
