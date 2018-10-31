using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max;
    int min;
    int guess;

    // Use this for initialization
    void Start()
    {
        StartGame();
	}
    void StartGame()
    {
        
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to Mind Reader!");
        Debug.Log("Do you mind picking a number?");
        Debug.Log("Your number can't be higher than: " + max);
        Debug.Log("Or lower then: " + min);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Up arrow equals higher, down arrow equals lower, enter equals correct.");
        Debug.Log("Let's get started! :)");
        max = max + 1;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
           
            min = guess;
            NextGuess();
            
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            
            max = guess;
            NextGuess();

        }
        
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("HAHA I win!");
            StartGame();
        }
    }
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than: " + guess);
    }
}
