using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypingDisplay : MonoBehaviour
{
    public Text  WordInput;

    public WordManager WordManager;

    public char[] EachText;

    public string TextInput;

    public string EmptyText = " ";

    [SerializeField] public float TypingTimer = 0.0f;

    void Start()
    {
        WordInput = GetComponent<Text>();
    }

    public void ResetType() //Reset TypeDisplay Method
    {
        if (WordInput.text != EmptyText)
        {
            WordInput.text = WordInput.text.Substring(0, WordInput.text.Length - WordInput.text.Length);
            // Remove by using it remove all len
        }
    }

    void Update()
    {
        foreach (char input in Input.inputString)
        {
            if (input == '\b') // has backspace/delete been pressed?
            {
                if (WordInput.text.Length != 0)
                {
                    WordInput.text = WordInput.text.Substring(0, WordInput.text.Length - 1);
                }
            }
            else if ((input == '\n') || (input == '\r')) // enter/return
            {
                //print("User entered their name: " + WordInput.text);
                TextInput = WordInput.text.ToString();
                EachText = TextInput.ToCharArray();
                if (TextInput == WordManager.RealAnswer())
                {
                    foreach(char letter in EachText)
                    {
                        WordManager.TypeLetter(letter);
                    }
                    for (int i = 0; i < TextInput.Length; i++)
                    {
                        WordInput.text = WordInput.text.Substring(0, WordInput.text.Length - 1);
                    }
                    
                    /* TextInput = " "; //Set TextInput to empty
                    EachText = EmptyText.ToCharArray(); //Set EachText to empty */
                    /* foreach (var text in EachText)
                    {
                        Debug.Log(text);
                    }
                    Debug.Log($"TextInput = {TextInput}"); */
                }
                else
                {
                    Debug.Log("Wrong, Try again");
                }   
            }
            else
            {
                WordInput.text += input;
            }
        }

    }

}
