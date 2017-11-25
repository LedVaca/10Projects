using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Move3D : MonoBehaviour {
	private Transform posi; 
	public float speed; 
	private int count;
	public GameObject GameOverText3D;
	public GameObject GameOverImage3D;
	public Text countText;
	private Transform positt;


	// Use this for initialization
	void Start () {
		positt = GetComponent <Transform> ();
		speed = 8;
		int count = 0;
		countText.text= "Score : " + count;
		GameOverImage3D.SetActive (false);
		GameOverText3D.SetActive (false);
	}
	
	// Update is called once per frame
	void Update (){
		if (count < 10){
			if (Input.GetKey(KeyCode.A)){
				positt.Translate (Vector3.left* Time.deltaTime * speed);
			}
				if (Input.GetKey(KeyCode.D)){
				positt.Translate (Vector3.right* Time.deltaTime * speed);
					}
				if (Input.GetKey(KeyCode.W)){
				positt.Translate (Vector3.forward* Time.deltaTime * speed);
						}
				if (Input.GetKey(KeyCode.S)){
				positt.Translate (Vector3.back* Time.deltaTime * speed);
							}

		}
		if(count == 10){
			countText.text= " You Win";

		}
	}
	void OnTriggerEnter(Collider other) {
		Destroy (other.gameObject);
		count = count + 1;



		countText.text = "Score : " + count;

		if (count == 10){
			GameOverImage3D.SetActive (true);
			GameOverText3D.SetActive (true);

		}

	}
}
