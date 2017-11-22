using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jugador_FB : MonoBehaviour {

	private Rigidbody2D rb2d;
	public	float jumpForce = 100f;
	private int count;
	public Text countText;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		int count = 0;
		countText.text= "Score: " + count;
	}

	// Update is called once per frame
	void Update () {
		// jump
		if (Input.GetKeyUp (KeyCode.Space)) {
			rb2d.velocity = Vector2.zero;
			rb2d.AddForce (new Vector2 (0, jumpForce));
			countText.text = "Score : " + count;


		}
	}
		void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("Coin_FB")) {
			count = count + 1;

		}
		if (other.CompareTag ("Enemigo_FB")) {
			Time.timeScale = 0;

		}

	}
}

