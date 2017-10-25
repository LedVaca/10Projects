using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour {
	[SerializeField] GameObject enem;
	[SerializeField] GameObject enem2;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine (createEne());
	}

		IEnumerator createEne()
		{
		
			for (int i = -5; i < 5; i++) {

				for (int s = 4; s < 5; s++) {
				Instantiate (enem2, new Vector3 (i, s, 0), Quaternion.identity);
				yield return new WaitForSeconds(0.01f);
				}
					for (int a = 3; a > 0; a--) {
					Instantiate (enem, new Vector3 (i, a, 0), Quaternion.identity);
					yield return new WaitForSeconds(0.01f);
					}
					

			}
	}
}
