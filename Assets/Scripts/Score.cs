using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public WordManager wordManager;
    void Update() 
    {
        scoreText.text = wordManager.Score();    
    }    
}

