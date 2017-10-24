using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Juugador : MonoBehaviour {

	[SerializeField] float Acumularfuerza = 0;
	[SerializeField] private GameObject stepPrefab;
	private float currentx = - 7f;
	private float currenty = 5f;


	private bool jump;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();


	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)&& !jump) {
			Acumularfuerza += 10;
		}


		if (Input.GetKeyUp (KeyCode.Space)) {
			
			jump = true;
			Invoke ("ResetJump", 0.2f);
		}
			
	}
	private void FixedUpdate (){
		if (jump) {
			rb.AddForce (new Vector3 (-Acumularfuerza * 0.3f, Acumularfuerza, 0));

		}
	}
	void ResetJump()
	{
		jump = false; 
		Acumularfuerza = 0;

	}
	void OnCollisionEnter (Collision other)
	{
		if (other.transform.CompareTag("Ball")){
			Debug.Log ("Lo toca");
			Vector3 ran = new Vector3 (currentx,currenty, 0);
			currentx += -7f;
			currenty += 5f;
			Instantiate (stepPrefab,ran,Quaternion.identity);
		}

	}
	void OnCollisionExit (Collision other){
		Destroy(other.gameObject);
	}
}

