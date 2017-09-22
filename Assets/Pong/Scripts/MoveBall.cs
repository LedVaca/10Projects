using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour {
	private Rigidbody2D rb;

	public int pun;

	// Use this for initialization
	void Start () {
		Invoke ("StartBall",2);
		pun = 0;

	}
	
	// Update is called once per frame
	void StartBall () {
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2 (6f, 6f);
	}
	void OnTriggerEnter2D (Collider2D other){
		Destroy (this.gameObject);
		pun = +1;
		Instantiate (this, new Vector2(0,0),Quaternion.identity);

	}


	}

			
	

