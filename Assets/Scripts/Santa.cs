using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class Santa : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void MoveDirection(){
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject.Find("oof").GetComponent<AudioSource>().Play();
    }
}
