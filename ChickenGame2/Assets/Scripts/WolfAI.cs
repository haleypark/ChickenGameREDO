using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAI : MonoBehaviour {
	public float speed;
	public Transform target;
	public Transform enemy;
	public int damage=1;
	public GameObject pcHealth;

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
		if(other.gameObject.tag == "Player"){
			
			print("The wolf sees you.");
			transform.LookAt(enemy);
			transform.Translate(Vector3.forward*speed*Time.deltaTime);
		}
		if(other.gameObject.tag == "Chicken"){
			
			print("The wolf as found a chicken!");
			transform.LookAt(target);
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
	else{
		MoveForward();
	}
}
void OnCollisionEnter(Collision other){

	if(other.gameObject.name == "Player"){

	var hit = other.gameObject;
	var health = hit.GetComponent<PlayerHealth>();
	print("Wolf is attacking!");

	if(pcHealth!= null){
		pcHealth.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
		// health.TakeDamage(damage);
		}
	}
}

	

	// void OnTriggerStay(Collider other){
	// 	if(other.gameObject.tag == "Player"){
	// 		Debug.Log("Player has entered wolfs trigger");
	// 		print("The wolf sees you.");
	// 		transform.LookAt(enemy);
	// 		transform.Translate(Vector3.forward*speed*Time.deltaTime);
	// 	}
	// 	if(other.gameObject.tag == "Chicken"){
	// 		Debug.Log("Chicken has entered wolfs trigger");
	// 		print("The wolf as found a chicken!");
	// 		transform.LookAt(target);
	// 		transform.Translate(Vector3.forward*speed*Time.deltaTime);
	// 	}
	// }
	
}
