using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePlayer2 : MonoBehaviour {
	[SerializeField]float speed;


	// Use this for initialization
	void Start () {
		
	
		speed = 15;
	
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (Vector2.up * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (Vector2.down * Time.deltaTime * speed);
		}
	}
}