using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy_P : MonoBehaviour {
	public Text gameO;
	public GameObject GameOverImage;

	// Use this for initialization
		void Start () {
		
		GameOverImage.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnCollisionEnter (Collision other){
		Destroy (other.gameObject);
		Time.timeScale=0;
		gameO.text =("Game Over");
		GameOverImage.SetActive(true);
	}

}



