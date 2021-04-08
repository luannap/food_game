using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheeseburger : MonoBehaviour
{
    public const int CALORIES = 350, FAT = 5, VITAMINS = 1, ENERGY = 5;
    public Stats stats;
    public AudioSource audio22;
    public FoodDataDisplay F22;
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
            audio22.Play();
            F22.FoodDataShow(VITAMINS, CALORIES, FAT);

            stats.IncreaseCalories(CALORIES);
            stats.IncreaseFat(FAT);
            stats.IncreaseVitamins(VITAMINS);
            stats.IncreaseEnergy(ENERGY);
            Destroy(gameObject);
        }
    }
}
