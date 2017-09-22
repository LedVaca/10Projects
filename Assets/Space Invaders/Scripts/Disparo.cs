using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour {



	public GameObject shot;
	public Transform shotspawner;
	private float nextf;
	private float ratef = 0.5f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.Space) && Time.time > nextf) {
			nextf = Time.time + ratef;
			Instantiate (shot, shotspawner.position, Quaternion.identity);

		}
	}


} 
