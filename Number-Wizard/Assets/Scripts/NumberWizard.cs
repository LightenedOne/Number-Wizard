using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int min;
    int max;
    int currentGuess;
    bool isFirstMove = true;
    // Start is called before the first frame update
    void Start()
    {
        InitializeGame();
    }

    // Update is called once per frame
    void Update()
    {
        PlayGame();
    }

    void InitializeGame()
    {
        min = 1;
        max = 1000;
        currentGuess = 500;
        Debug.Log("Welcome, I am the Number Wizard.");
        Debug.Log("Welcome to my little game.");
        Debug.Log("I will be guessing a number that you pick.");
        Debug.Log("The number will be between " + min + " and " + max + ".");
        Debug.Log("Tell me if your number is higher or lower than " + currentGuess + ".");
        Debug.Log("Press the up arrow key for higher, press the down arrow key for lower. Your guess cannot be " + currentGuess + ".");
        Debug.Log("Press the enter key when it is correct.");
        max += 1;
        isFirstMove = true;
    }

    void PlayGame()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up arrow key was pressed.");
            min = currentGuess;
            currentGuess = (min + max) / 2;
            Debug.Log("Is it higher or lower than: " + currentGuess + "?");
            isFirstMove = false;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down arrow key was pressed.");
            max = currentGuess;
            currentGuess = (min + max) / 2;
            Debug.Log("Is it higher or lower than: " + currentGuess + "?");
            isFirstMove = false;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && !isFirstMove)
        {
            RandomResponse();
            InitializeGame();
        }
    }

    void RandomResponse()
    {
        float RNG = Random.value;
        if(RNG <= 0.333f)
        {
            Debug.Log("I am a genius.");
        }
        else if(RNG > 0.333f && RNG <= 0.666f)
        {
            Debug.Log("My intellect is incredible.");
        }
        else if (RNG > 0.666f)
        {
            Debug.Log("Truly, I am the Number Wizard.");
        }
    }
}
