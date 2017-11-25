using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Time_Runner : MonoBehaviour {
	public Text times;
	private float timessnum;
	// Use this for initialization
	void Start () {
		times.text += ("Time :") + UnityEngine.Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
