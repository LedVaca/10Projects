using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroys : MonoBehaviour {
	public Text Game;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnColliderEnter(Collider other){
		if (CompareTag ("Player"))
			Destroy(other.gameObject );
			Game.text = ("Game Over");



	}

		
}

