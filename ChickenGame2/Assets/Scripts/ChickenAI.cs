﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenAI : MonoBehaviour {
	
	public float speed = 5.0f;

	public float rotSpeed = 10.0f;
	Vector3 turnAround = new Vector3(0,1,0);

	void Update (){
		Wander();
	}
	void Wander(){
		transform.Translate(Vector3.forward*speed*Time.deltaTime);
	}

	void OnTriggerStay




}

	// public float speed = 5;
	// public float directionChangeInterval = 1;
	// public float maxHeadingChange = 30;
	
	// public int points = 10;

	// CharacterController controller;
	// float heading;
	// Vector3 targetRotation;
	
	// public Transform enemy;
	
	// public Transform target;

	// public Transform chickenPen;

	// void OnTriggerStay(Collider other){
	// 	if(other.gameObject.name == "Player"){
	// 		Debug.Log("Player has entered chickens trigger");
	// 		transform.LookAt(target);
	// 		transform.Translate(Vector3.back*speed*Time.deltaTime);
	// 	}
	// 	if(other.gameObject.name == "Wolf"){
	// 		Debug.Log("Wolf has entered chickens trigger");
	// 		transform.LookAt(enemy);
	// 		transform.Translate(Vector3.back*speed*Time.deltaTime);
	// 	}
	// }
// 	void OnCollisionEnter(Collision other){
// 		if(other.gameObject.name == "Player"){
// 			ScoreManager.AddPoints(points);
// 			transform.position = chickenPen.position;
// 			transform.rotation = chickenPen.rotation;
// 		}
// 	}

// 	void Awake (){
// 		controller = GetComponent<CharacterController>();

// 		heading = Random.Range(0,360);
// 		transform.eulerAngles = new Vector3(0, heading, 0);

// 		StartCoroutine(NewHeading());
// 	}
// 	void Update (){
// 		transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, targetRotation, Time.deltaTime * directionChangeInterval);
// 		var forward = transform.TransformDirection(Vector3.forward);
// 		controller.SimpleMove(forward * speed);
// 	}
// 	IEnumerator NewHeading (){
// 		while (true) {
// 			NewHeadingRoutine();
// 			yield return new WaitForSeconds(directionChangeInterval);
// 		}
// 	}
// 	void NewHeadingRoutine(){
// 		var floor = Mathf.Clamp(heading - maxHeadingChange, 0, 360);
// 		var ceil = Mathf.Clamp(heading + maxHeadingChange, 0, 360);
// 		heading = Random.Range(floor, ceil);
// 		targetRotation = new Vector3(0, heading, 0);
// 	}

// }
//quaternion messures in degrees

