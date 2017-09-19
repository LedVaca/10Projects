using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	private int count;
	private int en1 = 100;
	private int en2 = 250;

	// Use this for initialization
	void Start () {
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D (Collider2D other) {
		if (other.CompareTag ("En1")) {
			Destroy (other.gameObject);
			count =count +en1; 
			Destroy (this.gameObject);
			Debug.Log (count);
		}

		if (other.CompareTag ("En2")) {
			Destroy (other.gameObject);
			count = count +en2; 
			Destroy (this.gameObject);
			Debug.Log (count);

		}
	}
}
