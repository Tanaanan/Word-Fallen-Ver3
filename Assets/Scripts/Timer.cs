using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeValue = 0f;    
    public Text timeText; 

    public WordManager WordManager;
    
    void Update()
    {   
        DisplayTime(WordManager.TimeReturn());           
    }
    public void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float min = Mathf.FloorToInt(timeToDisplay / 60); 
        float sec = Mathf.FloorToInt(timeToDisplay % 60);
        //string Final = ($"{Convert.ToString(min)} : {Convert.ToString(sec)}");
        string Final = ($"{Convert.ToString(sec)} / {WordManager.TimePerWord.ToString()}");
        timeText.text = Final;
    }
}