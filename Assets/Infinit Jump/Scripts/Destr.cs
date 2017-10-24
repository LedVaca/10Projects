using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destr : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

void OnCollisionExit (Collision other){
	Destroy(gameObject);
}
}
