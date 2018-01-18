using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuStartGame : MonoBehaviour {

	// Instanciar controladores
	public ParallaxController parallaxController;	

	public enum GameState {Idle, Playing};
	public GameState gameState = GameState.Idle;
	public GameObject buttonStart;
	//public GameObject personaje;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Empieza el juego
		if (gameState == GameState.Idle && (Input.GetMouseButtonDown(0))) {
			gameState = GameState.Playing;
			buttonStart.SetActive(false);
			//personaje.SendMessage("UpdateState", "Run");
		} else if (gameState == GameState.Playing) {
			parallaxController.Parallax();
		}	
	}
}
