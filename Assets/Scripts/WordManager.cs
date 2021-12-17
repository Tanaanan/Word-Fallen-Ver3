using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{    
    [SerializeField] public List<Word> words_List;    
    [SerializeField] public bool hasActiveWord;
    [SerializeField] public Word activeWord;

    public float TimePerWord = 10.0f;

    public WordSpawner wordSpawner;
    public Timer TimerVar;

    public TypingDisplay TypingDisplay;

    void Start() 
    {
        AddWord();
    }
    public void AddWord() // Genarate Word
    {
        Word word = new Word(WordGenarator.GetRandomWord(), wordSpawner.SpawnWord());
        Debug.Log(word.word);
        words_List.Add(word);
    }
    
    public int sum = 0;   
    public int score = 0; 
    public void TypeLetter(char letter)
    {
        if(hasActiveWord)
        {
            if(activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
                sum++;
            }

        }
        else
        {
            if (words_List[0].GetNextLetter() == letter ) 
            {
                hasActiveWord = true;
                activeWord = words_List[0];                
                words_List[0].TypeLetter();
            }

        }

        if(hasActiveWord && activeWord.WordTyped()) // CompleteDeleted
        {
            hasActiveWord = false;
            words_List.Remove(activeWord);
            AddWord(); //Addword
            TimeReset();
            sum = 0;
            score++;
        }
    }
    public void TimerRemove() //Deleted Timeout
    {
        if((TimerRun >= TimePerWord) && (hasActiveWord == true))
        {
            for (int x = 1; x < activeWord.Lenght() - sum; x++) //Loop index 
            {
                activeWord.TypeLetter();
            }
            
            TypingDisplay.ResetType(); //Reset TypingDisplay
            activeWord.WordTyped(); //Remove display on screen
            hasActiveWord = false;
            words_List.Remove(activeWord);
            AddWord();
            TimeReset();
            score--;
        }
        else if((TimerRun >= TimePerWord) && (hasActiveWord == false))
        {
            activeWord = words_List[0]; // Simulate Activeword
            hasActiveWord = true;

            for (int x = 0; x < activeWord.Lenght(); x++) //Loop index 
            {
                activeWord.TypeLetter();
            }
            
            TypingDisplay.ResetType(); //Reset TypingDisplay
            activeWord.WordTyped(); //Remove display on screen
            hasActiveWord = false;
            words_List.Remove(activeWord);
            AddWord();
            TimeReset();
            score--;
        }
    }
    public string Score()
    {
        return score.ToString();
    }

    [SerializeField] public float TimerRun = 0f;
    public float TimeReturn()
    {
        return TimerRun;       
    }
    public void TimeReset()
    {
        TimerRun = 0f;
    }

    public string RealAnswer()
    {
        return words_List[0].StringWord();
    }

    public void ScoreOverLoad()
    {
        if (score < 0)
        {
            score = 0;
        }
    }

    private void Update() 
    {
        TimerRun += Time.deltaTime;
        TimerRemove();
        ScoreOverLoad();
    }       
}