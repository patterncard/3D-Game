using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {
    private int requiredCoins;
    private Game game;
	// Use this for initialization
	void Start () {
        game = FindObjectOfType<Game>();
        requiredCoins = GameObject.FindGameObjectsWithTag("Coin").Length;
	}
	
    public void CheckForCompletion(int coinCount)
    {
        if (coinCount >= requiredCoins)
        {
            game.LoadNextLevel();
        }
        else
        {
            Debug.LogFormat("You need more coins! You have {0} out of {1}", coinCount, requiredCoins);
        }
    }
}
