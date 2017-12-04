using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GOver : MonoBehaviour {
	public Text Over;


	// Use this for initialization
		void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}
		void OnTriggerEnter(Collider other) {
		if(other.CompareTag("Over")){
			Over.text= "";
			Destroy(this.gameObject);
		}
	}

}
	

