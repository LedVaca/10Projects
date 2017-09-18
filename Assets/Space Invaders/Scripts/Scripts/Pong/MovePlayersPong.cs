﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePlayersPong : MonoBehaviour {
	[SerializeField] float speed;
	[SerializeField] Transform RightPlayer;
	[SerializeField] Transform LeftPlayer;


	// Use this for initialization
	void Start () {
		
	
		speed = 10;
	
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			LeftPlayer.Translate (Vector2.up * Time.deltaTime * speed);

		}
		if (Input.GetKey (KeyCode.S)) {
			LeftPlayer.Translate (Vector2.down * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			RightPlayer.Translate (Vector2.up * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			RightPlayer.Translate (Vector2.down * Time.deltaTime * speed);
		}
	}
}