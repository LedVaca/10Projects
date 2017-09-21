using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move_Player : MonoBehaviour {
	private Transform mytrans; 
	public float speed; 
	private int count;
	public Text countText;
	public Text win;


	// Use this for initialization
	void Start () {
		mytrans = GetComponent <Transform> ();
		speed = 5;
		int count = 0;
		countText.text= "Score: " + count;
	}
	
	// Update is called once per frame
	void Update (){
		if (count < 10){
			if (Input.GetKey(KeyCode.A)){
				mytrans.Translate (new Vector2 (-speed,0 ) * Time.deltaTime);
			}
					if (Input.GetKey(KeyCode.D)){
						mytrans.Translate (new Vector2 (speed,0) * Time.deltaTime);
					}
						if (Input.GetKey(KeyCode.W)){
							mytrans.Translate (new Vector2 (0,speed) * Time.deltaTime);
						}
							if (Input.GetKey(KeyCode.S)){
								mytrans.Translate (new Vector2 (0,-speed) * Time.deltaTime);
							}

		}
		if(count == 10){
			countText.text= " You Win";

		}
	}
	void OnTriggerEnter(Collider other) {
		Destroy (other.gameObject);
		count = count + 1;



		countText.text = "Score: " + count;

		if (count == 10){
			countText.text= " You Win";

		}

	}
}
