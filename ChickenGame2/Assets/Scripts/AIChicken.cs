using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIChicken : MonoBehaviour {

	public float speed = 2f;
	public float rotSpeed = 50f;
	public Transform wolf;
	public Transform player;
	Vector3 turnAround = new Vector3(0,1,0);
	public Quaternion rot;
	void OnTriggerStay(Collider other){
		if(other.gameObject.tag == "player"){
			transform.rotation = new Quaternion(0,100,0,0);
			transform.Translate(Vector3.forward*speed*Time.deltaTime);
		}
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Wander ();

		
	}
	void OnTriggerStay2(Collider other){
		if(other.gameObject.tag == "wall"){
			transform.Rotate(turnAround*rotSpeed*Time.deltaTime);
		}
		
	}
	void Wander(){
		transform.Translate(Vector3.forward*speed*Time.deltaTime);
	}
}
