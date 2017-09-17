using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePlayer : MonoBehaviour {
	[SerializeField]float speed;



	// Use this for initialization
	void Start () {
		
	
		speed = 15;
	
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate(Vector2.up * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (Vector2.down * Time.deltaTime * speed);

		}
	
	}

}
