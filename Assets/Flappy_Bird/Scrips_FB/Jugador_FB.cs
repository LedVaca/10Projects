using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador_FB : MonoBehaviour {

	private Rigidbody2D rb2d;
	public	float jumpForce = 0;



	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();

	}

	// Update is called once per frame
	void Update () {
		// jump
		if (Input.GetKeyUp (KeyCode.Space)) {
			rb2d.AddForce (Vector2.up *jumpForce);

			Debug.Log ("brica");

		}
	}
}
