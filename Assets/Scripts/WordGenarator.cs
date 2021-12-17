using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class WordGenarator : MonoBehaviour
{
	void Start() 
	{
		Shuffle_List = wordList.OrderBy(x => Guid.NewGuid()).ToList(); //using Linq (OrderBy) and Guid to Shuffle list
	}

	public static List<string> Shuffle_List = new List<string>();/* 
	public static List<string> wordList = new List<string>()
									{"sidewalk", "robin", "three", "protect", "periodic",
									"somber", "majestic", "jump", "pretty", "wound", "jazzy",
									"memory", "join", "crack", "grade", "boot", "cloudy", "sick",
									"mug", "hot", "tart", "dangerous", "mother", "rustic", "economic",
									"weird", "cut", "parallel", "wood", "encouraging", "interrupt",
									"guide", "long", "chief", "mom", "signal", "rely", "abortive",
									"hair", "representative", "earth", "grate", "proud", "feel",
									"hilarious", "addition", "silent", "play", "floor", "numerous",
									"friend", "pizzas", "building", "organic", "past", "mute", "unusual",
									"mellow", "analyse", "crate", "homely", "protest", "painstaking",
									"society", "head", "female", "eager", "heap", "dramatic", "present",
									"sin", "box", "pies", "awesome", "root", "available", "sleet", "wax",
									"boring", "smash", "anger", "tasty", "spare", "tray", "daffy", "scarce",
									"account", "spot", "thought", "distinct", "nimble", "practise", "cream",
									"ablaze", "thoughtless", "love", "verdict", "giant"};    */

	public static List<string> wordList = new List<string>()
									{"sidewalk", "robin", "Cute", "Kawaii", "Test"};   

    public static string GetRandomWord()
    {
        if (Shuffle_List.Count > 0)
		{
			//int randomIndex = UnityEngine.Random.Range(0, wordList.Count);
			string randomWord  = Shuffle_List[0];
			Shuffle_List.RemoveAt(0); //Remove Shuffle_Word[0]
			return randomWord; 
		}
		else
		{
			string GameEnd = "GameEnd!!";
			return  GameEnd;
		}
		
    }
}
