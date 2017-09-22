using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public int puntitos;
	public int posco;

	public static GameManager GM;

	// Use this for initialization
	void Awake ()
	{
		if (GM == null) {
			GM = this;
			DontDestroyOnLoad (this);
		} 
		else {
			Destroy (gameObject);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
