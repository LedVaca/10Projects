using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour {
	public GameObject enemy;

	// Use this for initialization
	void Start () {
		for (int i = 0; i <10; i++){
			Instantiate(enemy,new Vector3(i,0,0),Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
