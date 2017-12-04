using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Jugadorr_2 : MonoBehaviour {

	[SerializeField] float speedd;
	private Rigidbody rb;
	private	float jumpForce = 50;
	private  bool jump ;
	public Text gameO;
	public GameObject GameOverImage;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();

		speedd = 7f;
		GameOverImage.SetActive (false);
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
			GameOverImage.SetActive(true);
			gameO.text = ("Game Over");
			Time.timeScale=0;

		}
	}
		



}
