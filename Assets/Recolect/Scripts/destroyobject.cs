using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroyobject : MonoBehaviour {
	private int count;
	public Text countText;
	public Text win;


	// Use this for initialization
		void Start () {
		int count = 0;
		countText.text= "Score: " + count;
		
	}
	
	// Update is called once per frame
	void Update () {
	}
		void OnTriggerEnter(Collider other) {
		Destroy (other.gameObject);
		count = count + 1;
		


		countText.text = "Score: " + count;
	
		if (count == 10){
			countText.text= " You Win";
			Destroy(this.gameObject);
	}

}

}

