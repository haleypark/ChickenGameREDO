﻿using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {
	
	public static int score;
	public Text text;
	void Start () {
		text = GetComponent<Text>();
			score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(score < 0)
			score = 0;
			
		// text.text =" " + score;
	}
	public static void AddPoints (int pointsToAdd){
		score += pointsToAdd;	
	}
	public void Reset(){
		score = 0;
	}
}


	
