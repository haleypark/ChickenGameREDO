using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generic : MonoBehaviour {
//position
// public float posX;
// public float posY;
// public float posZ;
public Vector3 pos;
public Quaternion rot; 
public Vector3 scale;

// public float rotX;
// public float rotY;
// public float rotZ;
// public float rotW;
	void Start (){
		scale = transform.localScale;
	}
	

	void Update () {
		// transform.position = new Vector3(posX,posY,posZ);
		// transform.rotation = new Quaternion(rotX,rotY,rotZ,rotW);
		transform.position = pos;
		transform.rotation = rot;
		scale = Vector3.one;
		
	}
}

