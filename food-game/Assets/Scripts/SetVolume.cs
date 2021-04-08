using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;
    public Text volumeText;
    public Slider slider;

    public void Update(){
        volumeText.text = "" + Math.Round(slider.value*100) + "%"; 
    }
    public void Start(){
        slider.value = PlayerPrefs.GetFloat("musicVol", 10f);
        mixer.SetFloat("musicVol", PlayerPrefs.GetFloat("musicVol"));
    }
    public void SetLevel(float sliderValue){
        PlayerPrefs.SetFloat("musicVol", sliderValue);
        mixer.SetFloat("musicVol", Mathf.Log10(sliderValue) * 20);
    }
}
