using System.Collections;
using System.Collections.Generic;
using Application;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour {

    public string sceneName = "StartScene";

	// Use this for initialization
	void Start () {
    GetComponent<Button>().onClick.AddListener(() =>
        {
            Globals.ResetGame();
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        });
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
