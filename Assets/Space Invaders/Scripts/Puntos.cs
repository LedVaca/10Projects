using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Puntos : MonoBehaviour {
	
	public Text puntos;
	 
	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		puntos.text= "Score: " + GameManager.GM.puntitos;
	}
}
