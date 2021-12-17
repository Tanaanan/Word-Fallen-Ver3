using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordRemain : MonoBehaviour
{
    public WordGenarator WordGenarator;
    public Text WordRemaining; 
    void Start()
    {
        WordRemaining = GetComponent<Text>();
    }

    public string WordLeft()
    {
        int RealWordLeft = WordGenarator.Shuffle_List.Count + 1;
        return WordRemaining.text =  RealWordLeft.ToString() + " / " + WordGenarator.wordList.Count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        WordLeft();
    }
}
