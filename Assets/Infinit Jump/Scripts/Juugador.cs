using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Juugador : MonoBehaviour {

	[SerializeField] float Acumularfuerza = 0;
	[SerializeField] private GameObject stepPrefab;
	[SerializeField] private Text scor;
	private float currentx = - 7f;
	private float currenty = 5f;
	private int plat;


	private bool jump;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		plat = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
		scor.text = "Score : " + plat;

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
			currentx += -5.6f;
			currenty += 3f;
			Vector3 ran = new Vector3 (currentx,currenty, 0);
			Instantiate (stepPrefab,ran,Quaternion.identity);
			plat += 10;
		}

	}


}

