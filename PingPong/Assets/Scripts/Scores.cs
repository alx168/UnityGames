using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Scores : MonoBehaviour
{
	public int score1 = 0;
	public int score2 = 0;

	public Text Player1Score, Player2Score;
	
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void UpdateScore(int first, int second){
    	score1 += first;
    	score2 += second;
    	Player1Score.text = "" + score1;
    	Player2Score.text = "" + score2;
    	


    }
}
