using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveEnemys : MonoBehaviour {
	private Transform ene;	
	public float velocidad;


	// Use this for initialization
	void Start () {
		InvokeRepeating ("MoveEne", 0.1f, 0.3f);
		ene = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void MoveEne () {
		ene.position += Vector3.right * velocidad;

		foreach (Transform enem in ene) {
			if (ene.position.x < -8 || ene.position.x > 8){
				velocidad = -velocidad;
				ene.position += Vector3.down * 0.5f;
				return;
		}

			
		}
		
	}
}
