//Jan Kopejtko, 2022

using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class slider : MonoBehaviour
{
    [SerializeField] Text sliderValue; //text that will show value from slider
    [SerializeField] Slider sliderBox; //UI slider

    private void Awake()
    {
        //todo load value
        //sliderBox.value = loadFromUserData(slider);
    }
    void getValue()
    {
        //get slider value then multiplied by 100 --> (%)
        //convert to int so there won't be any number after dot
        //convert to string so the value could be stored in text
        sliderValue.text = ((int)(sliderBox.value * 100)).ToString();
        //todo
        //saveUserData(slider, slider.value) //--> float
    }
    private void Update()
    {
        //this function will be called every frame (recource consuming) --> need optimalization
        getValue();
    }
}