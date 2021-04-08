using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodDataDisplay : MonoBehaviour
{
    public Text Vitamins;
    public Text Calories;
    public Text FAT;

    // Start is called before the first frame update

    void Start()
    {
        Vitamins.text = " ";
        Calories.text = " ";
        FAT.text = " ";
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    public void FoodDataShow(int v, int c, int f)
    {
        Vitamins.enabled = true;
        Calories.enabled = true;
        FAT.enabled = true;

        if(v == 0)
        {
            Vitamins.text = "";
        }
        else
        {
            Vitamins.text = "+" + v;
        }
        if(c == 0)
        {
            Calories.text = "";
        }
        else
        {
            Calories.text = "+" + c;
        }
        if (f == 0)
        {
            FAT.text = "";
        }
        else
        {
            FAT.text = "+" + f;
        }

        Invoke("Hide", 1f);

    }

    public void Hide()
    {

        Vitamins.enabled = false;
        Calories.enabled = false;
        FAT.enabled = false;
    }




}
