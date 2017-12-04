using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugadorr_2 : MonoBehaviour {

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
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (Vector3.left* UnityEngine.Time.deltaTime * speedd);

		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (Vector3.right * UnityEngine.Time.deltaTime * speedd);
		}

		if (Input.GetKeyDown (KeyCode.UpArrow)&& !jump){
			rb.AddForce (Vector3.up * jumpForce, ForceMode.Impulse);


			
				}
			}
	void OnCollisionExit (Collision other){
		jump = true;
	}
	void OnCollisionEnter (Collision other){
		jump = false;

	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Enemigo_FB")) {

			Destroy (gameObject);


			Time.timeScale=0;
		}
	}
		



}
