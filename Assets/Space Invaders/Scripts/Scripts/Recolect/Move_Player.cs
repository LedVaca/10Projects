using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Player : MonoBehaviour {
	private Transform mytrans; 
	public float speed; 


	// Use this for initialization
	void Start () {
		mytrans = GetComponent <Transform> ();
		speed = 5;

	}
	
	// Update is called once per frame
	void Update (){
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
}
