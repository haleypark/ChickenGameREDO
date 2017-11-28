using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderIC : MonoBehaviour {

	public float speed = 5;
	public Transform chickenPen;
	public Transform chickenGraveYard;
	public int points = 10;
	public Transform target;

	void MoveForward(){
		transform.Translate(Vector3.forward*speed*Time.deltaTime);
	}

	void Turn(){
		int randomNum = Random.Range(0,360);
		transform.Rotate(0,randomNum,0);
	}
	void OnTriggerStay(Collider other){
		if(other.gameObject.tag == "CheckPoint"){
			Turn();
		}
		else if(other.gameObject.tag == "Player"){
			transform.LookAt(target);
			transform.rotation = Quaternion.Inverse (target.rotation); 
			transform.Translate(Vector3.forward*speed*Time.deltaTime);
			
		}
		else{
			MoveForward();
		}

	}
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "wall"){
			transform.Rotate(0,180,0);
		}
		
	}
	void OnCollisionEnter(Collision other){
		if(other.gameObject.tag == "Player"){
			ScoreManager.AddPoints(points);
			transform.position = chickenPen.position;
			transform.rotation = chickenPen.rotation;
		}
		if(other.gameObject.tag == "wolf"){
			//need to add something here to remove points.
			transform.position = chickenGraveYard.position;
			transform.rotation = chickenGraveYard.rotation;
		}
	
	}
}
