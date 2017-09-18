using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour {
	private Rigidbody2D rb;



	// Use this for initialization
	void Start () {
		Invoke ("StartBall",2);


	}
	
	// Update is called once per frame
	void StartBall () {
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2 (3f, 3f);
	}

	}

			
	

