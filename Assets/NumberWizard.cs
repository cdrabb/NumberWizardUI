using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max;
    int min;
    int guess;
    public int maxGuessesAllowed = 5;
    public Text text;

    // Use this for initialization
    void Start () {
        StartGame();
	}
	

    public void GuessHigher() {
        min = guess;
        NextGuess();
    }

    public void GuessLower() {
        max = guess;
        NextGuess();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max+1);
        maxGuessesAllowed -= 1;
        text.text = guess.ToString();

        if (maxGuessesAllowed == 0) {
            Application.LoadLevel("Win");
        }
    }
}
