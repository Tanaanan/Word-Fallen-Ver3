using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word 
{    
    public string word;
    public int typeIndex;
    public int Lenght_word;
    WordDisplay display;

    public Word (string _word, WordDisplay _display)
    {
        word = _word;
        typeIndex = 0;

        display = _display;
        display.SetWord(word);
    }

    public char GetNextLetter()
    {
        return word[typeIndex];
    }

    public char FirstIndex()
    {
        return word[0];
    }

    public void TypeLetter()
    {
        typeIndex++;
        display.RemoveLetter();   
    }

    public int Lenght()
    {
        int Lenght_word = word.Length;
        return Lenght_word;        
    }

    public string StringWord() //Convert String to Word
    {
        return word.ToString();
    }

    public bool WordTyped()
    {
        bool wordTyped = (typeIndex >= word.Length);
        if(wordTyped)
        {
            // Remove the word on screen
            display.RemoveWord();
        }
        return wordTyped;
    }  
}
