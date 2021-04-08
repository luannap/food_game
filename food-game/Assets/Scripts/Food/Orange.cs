using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orange : MonoBehaviour
{
    public const int CALORIES = 60, FAT = 0, VITAMINS = 3, ENERGY = 10;
    public Stats stats;
    public AudioSource audio24;
    public FoodDataDisplay F24;

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
            audio24.Play();
            F24.FoodDataShow(VITAMINS, CALORIES, FAT);

            stats.IncreaseCalories(CALORIES);
            stats.IncreaseFat(FAT);
            stats.IncreaseVitamins(VITAMINS);
            stats.IncreaseEnergy(ENERGY);
            Destroy(gameObject);
        }
    }
}