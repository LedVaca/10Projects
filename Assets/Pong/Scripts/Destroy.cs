﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {
	private int ca; 
	public GameObject Ball;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("Ball")) {
			Destroy (other.gameObject);
			Instantiate (Ball, Vector2.zero, Quaternion.identity);
		}
	}

}
