﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour {



	public GameObject shot;
	public Transform shotspawner;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.Space)){
			Instantiate(shot, shotspawner.position, Quaternion.identity);

		}
	}
} 