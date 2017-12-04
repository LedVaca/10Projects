using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dest_R3D : MonoBehaviour {
	private int count;
	public Text countText;
	public Text win;
	[SerializeField] Text Over;



	// Use this for initialization
		void Start () {
		int count = 0;
		countText.text= "Score: " + count;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.y < 0) {
			Destroy (gameObject);
			Over.text = "Game Over";
			Debug.Log ("Muere");
		}
	}
		void OnTriggerEnter(Collider other) {
		Destroy (other.gameObject);
		count = count + 1;
		


		countText.text = "Score: " + count;
	
		if (count == 10){
			
			Destroy(this.gameObject);
	}

}

}

