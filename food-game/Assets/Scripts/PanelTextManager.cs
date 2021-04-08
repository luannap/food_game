using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PanelTextManager: MonoBehaviour
{
    //public int score = 0;
    public Text scoreTxt;
    public Text CaloriesTxt;
    public Text FATTxt;
    public Text VitaminsTxt;
 //   public Text HintTxt;

    public Stats s;

    // Start is called before the first frame update

    public void Update()
    {
       
        DisplayScore();
        DisplayCalories();
        DisplayFAT();
        DisplayVitamins();
       // DisplayHint();
    }

    //overloaded functions are good clean programming practice

    private void DisplayScore()
    {
        scoreTxt.text = "Score: " + s.GetScore();
    }


    private void DisplayCalories()
    {
        CaloriesTxt.text = "Calories: " + s.GetCalories();
    }


    private void DisplayFAT()
    {
        
        FATTxt.text = "Fat: " + s.GetFat();
    }


    private void DisplayVitamins()
    {
        VitaminsTxt.text = "Vitamins: " + s.GetVitamins();
    }
/*
    public void DisplayHint()
    {
        HintTxt.text = "Hint: " + "";
    }

   */
}
