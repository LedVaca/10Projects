using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour {


	private  int en1 = 100 ;
	private  int en2 = 250 ;
	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnTriggerEnter2D (Collider2D other) {
		if (other.CompareTag ("En1")) {
			Destroy (other.gameObject);
			GameManager.GM.puntitos += en1;
			Destroy (this.gameObject);

		}

		if (other.CompareTag ("En2")) {
			Destroy (other.gameObject);
			GameManager.GM.puntitos += en2;
			Destroy (this.gameObject);


		}
	}
}
