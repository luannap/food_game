﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    const int CALORIES = 95, FAT = 0, VITAMINS = 3, ENERGY = 10;
    public Stats stats;
    public AudioSource audio23;
    public FoodDataDisplay F23;
    
    // Start is called before the first frame update
    void Start()
    {
        stats = GameObject.FindWithTag("GameController").GetComponent<Stats>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            audio23.Play();
            F23.FoodDataShow(VITAMINS, CALORIES, FAT);

            stats.IncreaseCalories(CALORIES);
            stats.IncreaseFat(FAT);
            stats.IncreaseVitamins(VITAMINS);
            stats.IncreaseEnergy(ENERGY);
            Destroy(gameObject);
        }
    }
}
