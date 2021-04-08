using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrenchFries : MonoBehaviour
{
    public const int CALORIES = 365, FAT = 3, VITAMINS = 0, ENERGY = 5;
    public Stats stats;
    public AudioSource audio12;
    public FoodDataDisplay F12;
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
            audio12.Play();
            F12.FoodDataShow(VITAMINS, CALORIES, FAT);

            stats.IncreaseCalories(CALORIES);
            stats.IncreaseFat(FAT);
            stats.IncreaseVitamins(VITAMINS);
            stats.IncreaseEnergy(ENERGY);
            Destroy(gameObject);
        }
    }
}
