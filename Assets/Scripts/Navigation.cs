using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Navigation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void goToCredits() {
		SceneManager.LoadScene ("About");
	}

	public void goToIntro() {
		SceneManager.LoadScene ("Intro");
	}

	public void goToGame() {
		SceneManager.LoadScene ("Game");
	}

}
