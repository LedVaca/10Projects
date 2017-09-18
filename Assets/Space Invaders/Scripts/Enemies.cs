using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour {
	[SerializeField] GameObject enemy;

	// Use this for initialization
	void Start () {
		
		for (int i = -5; i <5; i++){
			for (int a = 1; a <5; a++){
			Instantiate(enemy,new Vector3(i,a,0),Quaternion.identity);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
