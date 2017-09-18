using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	[SerializeField] float speed;

	// Use this for initialization
	void Start () {


		speed = 10f;

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A) && transform.position.x >-8) {
			transform.Translate (Vector2.left* Time.deltaTime * speed);

		}
		if (Input.GetKey (KeyCode.D) && transform.position.x<8) {
			transform.Translate (Vector2.right * Time.deltaTime * speed);
		}

	}
}