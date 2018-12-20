using System.Collections;
using System.Collections.Generic;
using Application;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponentInChildren<Text>().text = "Restart";

        GetComponent<Button>().onClick.AddListener(() =>
        {
            Globals.ResetGame();
            SceneManager.LoadScene("StartScene", LoadSceneMode.Single);
        });
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
