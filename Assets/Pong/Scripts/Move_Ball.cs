
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Ball : MonoBehaviour {
	private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2 (6f, 6f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
