﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	public const int maxHealth = 10;

	public int currentHealth = maxHealth;
	public Text hp;
	public Text maxHP;
	
void Update (){
	hp.text = currentHealth.ToString();
	maxHP.text = maxHealth.ToString();
}

public void TakeDamage(int amount){
	currentHealth -= amount;
	if(currentHealth <= 0){
		currentHealth=0;
		print("You're dead! Game Over!");
	}
}

	
}
