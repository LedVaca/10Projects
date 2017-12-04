using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTub_FB : MonoBehaviour {


	private Rigidbody2D rb2d;
	public float velocidad = -4;

	private	void Awake () {
		rb2d = GetComponent<Rigidbody2D> ();
	}	

		// Use this for initialization
	void Start (){
		
		rb2d.velocity = new Vector2 (velocidad, 0);
	
	}
	// Update is called once per frame
	void Update () {
		
	}
}
