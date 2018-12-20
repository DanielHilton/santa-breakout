using System.Collections;
using System.Collections.Generic;
using Application;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	void FixedUpdate () {
        GetComponent<Text>().text = Globals.Lives.ToString();
	}
}
