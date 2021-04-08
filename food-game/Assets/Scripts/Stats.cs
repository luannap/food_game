using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stats : MonoBehaviour
{
    public int calories, fat, vitamins, energy, score;
    // Start is called before the first frame update

    private float time = 0.0f;
    public float interpolationPeriod = 0.1f;

    void Start()
    {
        energy = 15;
    }

    // Update is called once per frame


    void Update()
    {
        updateScore();
        time += Time.deltaTime;
        if ((time/30) >= interpolationPeriod)
        {
            DecrementEnergy();
            time = 0.0f;
        }
    }
    public void DecrementEnergy()
    {
        energy -= 1;
        if (energy <= 0)
        {
            SceneManager.LoadScene("gameoverenergy");
        }
    }
    public void IncreaseCalories(int i)
    {
        calories += i;
    }
    public int GetCalories()
    {
        return calories;
    }
    public void IncreaseFat(int i)
    {
        fat += i;
    }
    public int GetFat()
    {
        return fat;
    }
    public void IncreaseEnergy(int i)
    {
        energy += i;
    }

    public int GetEnergy()
    { 
        return energy; 
    }
    public void IncreaseVitamins(int i)
    {
        vitamins += i;
    }
    public int GetVitamins()
    {
        return vitamins;
    }

    public void updateScore()
    {
        /*
         * The dietary reference intake (DRI) for fat in adults is 20% to 35% of total calories from fat.
         * That is about 44 grams to 77 grams of fat per day if you eat 2,000 calories a day.
        */

        /*if (calories == 0 || (fat * 20 / calories > 0.35 && fat / calories * 20 > 0.2))
        {
            score = vitamins * 10 + fat + calories / 10;
        }
        else
        {
            score = vitamins * 10 + (fat + calories)/10 * (1 - fat / calories);

        }*/
        score = (2000 - Mathf.Abs(calories - 2000)) * 10 - (fat % 20) * 10 + vitamins * 10;

        if (score < 0)
        {
            SceneManager.LoadScene("gameoverscore");
        }
    }

    public int GetScore()
    {
        return score;
    }
}
