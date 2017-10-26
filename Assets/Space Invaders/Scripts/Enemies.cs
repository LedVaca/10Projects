using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour {
	[SerializeField] GameObject enem;
	[SerializeField] GameObject enem2;
	private Transform ene;
	public float velocidad;
	private int ya; 




	// Use this for initialization
	void Start () 
	{
		StartCoroutine (createEne());
		InvokeRepeating ("MoveEne", 0.1f, 0.3f);
		ene = GetComponent<Transform> ();
	}


		
	IEnumerator createEne()
		{
		
			for (int i = -5; i < 5; i++) {
				ya = ya +1;
			for (int s = 4; s < 5; s++) {
				GameObject EChild = Instantiate (enem2, new Vector3 (i, s, 0), Quaternion.identity);
				EChild.transform.parent = GameObject.Find ("SpawnerEne").transform;
				yield return new WaitForSeconds (0.002f);

			}
				
				
					for (int a = 3; a > 0; a--) {
					GameObject EChild = Instantiate (enem, new Vector3 (i, a, 0), Quaternion.identity);
					EChild.transform.parent = GameObject.Find ("SpawnerEne").transform;	
					yield return new WaitForSeconds(0.002f);
					
					}
				}


				
		}
				

		

	//Moviemiento
	void MoveEne () {
		if ( ya > 9) {
			ene.position += Vector3.right * velocidad;

			foreach (Transform enem in ene) {
				if (ene.position.x < -3 || ene.position.x > 3) {
					velocidad = -velocidad;
					ene.position += Vector3.down * 1f;
					return;

				}
				if (enem.position.y <= -4) {
					Time.timeScale = 0;
				}
				if (ene.childCount == 1) {
					CancelInvoke ();
					InvokeRepeating ("MoveEne", 0.1f, 0.25f);
				}

			}

		}
	}
}



