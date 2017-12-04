using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigoo : MonoBehaviour {
	
	[SerializeField] GameObject eneP;
	public float velocida;
	private int s;



	// Use this for initialization
	void Start () {
		StartCoroutine (createCubo());


	}
		
		IEnumerator createCubo()
	{
		for (int s = -100; s < 100; s++) { 
			Vector3 position = new Vector3 (Random.Range (-3, 4), 0.06f, 50);
			GameObject EneChild = Instantiate (eneP, position, Quaternion.identity);
			EneChild.transform.parent = GameObject.Find ("SpawnerEne").transform;
			yield return new WaitForSeconds (20f * UnityEngine.Time.deltaTime);

		}
	}
	
	// Update is called once per frame
	void Update () {


		

	}

}
