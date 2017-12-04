using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemie_FB : MonoBehaviour {
	[SerializeField] GameObject enem;
	[SerializeField] GameObject enem2;
	[SerializeField] GameObject enem3;
	[SerializeField] GameObject enem4;
	[SerializeField] GameObject enem5;



	// Use this for initialization
	void Start () 
	{
		StartCoroutine (createEne());

	}


		
	IEnumerator createEne()
		{
		
			for (int i = -100; i < 100; i++) {
			

			for (int s = 0; s < 1; s++) {
				Instantiate (enem2, new Vector2 (10, 0), Quaternion.identity);
				yield return new WaitForSeconds (3f);

			
			}
					
			for (int a = 0; a < 1; a++) {
				Instantiate (enem, new Vector2 (10, 0), Quaternion.identity);
				yield return new WaitForSeconds (3f);
			
			}

	
			for (int c = 0; c < 1; c++) {
				Instantiate (enem3, new Vector2 (10,0), Quaternion.identity);
				yield return new WaitForSeconds(3f);

				}

			for (int e = 0; e < 1; e++) {
				Instantiate (enem4, new Vector2 (10, 0), Quaternion.identity);
				yield return new WaitForSeconds (3f);

			}	

			for (int f = 0; f < 1; f++) {
				Instantiate (enem5, new Vector2 (10, 0), Quaternion.identity);
				yield return new WaitForSeconds (3f);

			}	
				
		}
				
}
}



