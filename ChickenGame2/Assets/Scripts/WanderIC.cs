using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderIC : MonoBehaviour {

	public float moveSpeed = 5;

	void MoveForward(){
		transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
	}
	void Turn(){
		int randomNum = Random.Range(0,360);
		transform.Rotate(0,randomNum,0);
	}
	void OnTriggerStay(Collider other){
		if(other.gameObject.tag == "CheckPoint"){
			Turn();
		}
		else{
			MoveForward();
		}

	}
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "wall"){
			transform.Rotate(0,180,0);
		}
		else{
			MoveForward();
		}
	}
}
