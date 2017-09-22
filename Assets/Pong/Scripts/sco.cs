using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sco : MonoBehaviour {
	public Text cou;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		cou.text = "Score:" + GameManager.GM.posco;
	}
}
