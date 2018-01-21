using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		
	}

	public void LoadGame() {
		SceneManager.LoadScene ("Game");
	}

	public void LoadAbout(){
		SceneManager.LoadScene ("About");
	}

	public void Exit() {
		// Pendiente programar la cerrada del juego
	}

	public void LoadIntro() {
		SceneManager.LoadScene ("Intro");
	}
}
