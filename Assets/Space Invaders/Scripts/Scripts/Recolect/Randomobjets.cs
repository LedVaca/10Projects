using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomobjets : MonoBehaviour {

	// Use this for initialization
	public GameObject Enemy;

	private int ran = 0;

	void Start()
{
	for (ran = 0; ran <= 9; ran++){
		Vector2 rango = new Vector2(Random.Range(-9.4f,9.4f),Random.Range(-4.0f,4.0f));
			Instantiate (Enemy,rango,Quaternion.identity);
				
	}
}
}
	