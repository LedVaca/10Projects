using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugadorr : MonoBehaviour {

	[SerializeField] float speedd;
	private Rigidbody rb;
	private	float jumpForce = 50;
	private  bool jump ;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();

		speedd = 7f;

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector3.left* UnityEngine.Time.deltaTime * speedd);

		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector3.right * UnityEngine.Time.deltaTime * speedd);
		}

		if (Input.GetKeyDown (KeyCode.Space)&& !jump){
			rb.AddForce (Vector3.up * jumpForce, ForceMode.Impulse);


			
				}
			}
	void OnCollisionExit (Collision other){
		jump = true;
	}
	void OnCollisionEnter (Collision other){
		jump = false;

	}
		



}
