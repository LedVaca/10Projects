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
	private Rigidbody positt;


	// Use this for initialization
	void Start () {
		positt = GetComponent <Rigidbody> ();
		speed = 400;
		int count = 0;
		countText.text= "Score : " + count;
		GameOverImage3D.SetActive (false);
		GameOverText3D.SetActive (false);
	}
	
	// Update is called once per frame
	void Update (){
		if (count < 10){
			if (Input.GetKey(KeyCode.A)){
				positt.AddForce (Vector3.left* Time.deltaTime * speed);
			}
				if (Input.GetKey(KeyCode.D)){
				positt.AddForce (Vector3.right* Time.deltaTime * speed);
					}
				if (Input.GetKey(KeyCode.W)){
				positt.AddForce (Vector3.forward* Time.deltaTime * speed);
						}
				if (Input.GetKey(KeyCode.S)){
				positt.AddForce (Vector3.back* Time.deltaTime * speed);
							}

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
