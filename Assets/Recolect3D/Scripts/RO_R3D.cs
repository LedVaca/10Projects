using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RO_R3D : MonoBehaviour {

	// Use this for initialization
	public GameObject Enemy;

	private int ran = 0;

	void Start()
{
	for (ran = 0; ran <= 9; ran++){
			Vector3 rango = new Vector3(Random.Range(-12f,12f),1,Random.Range(-12f,12f));
			Instantiate (Enemy,rango,Quaternion.identity);
				
	}
}
}
	