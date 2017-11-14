using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAI : MonoBehaviour {
	public float speed;
	public Transform target;
	public Transform enemy;
	public int damage;
	public GameObject pcHealth;

	//enemy is player


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
//target is chicken
	

	void OnTriggerStay(Collider other){
		if(other.gameObject.tag == "Player"){
			Debug.Log("Player has entered wolfs trigger");
			transform.LookAt(enemy);
			transform.Translate(Vector3.forward*speed*Time.deltaTime);
		}
		if(other.gameObject.tag == "Chicken"){
			Debug.Log("Chicken has entered wolfs trigger");
			transform.LookAt(target);
			transform.Translate(Vector3.forward*speed*Time.deltaTime);
		}
	}
	
}
