using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	[SerializeField] GameObject score1;
	[SerializeField] GameObject score2;
	public int count1;
	public int count2;
	public Text Puntos;
	// Use this for initialization
	void Start () {
		count1 = 0;
		count2 = 0;
		Puntos.text = "Score: " + count1 + "- " + count2;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other) {
		if (this.score1)
		Destroy(other.gameObject);
		Destroy (other.gameObject);
		count1 = count1 + 1;



		Puntos.text = "Score: " + count;

		if (count == 10){
			countText.text= " You Win";

		}

	}
}
