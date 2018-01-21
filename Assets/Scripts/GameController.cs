using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public float mountainSpeed = 0.01f;
	public float floorSpeed = 0.15f;
	public float treesSpeed = 0.054f;
	public float branchesSpeed = 0.2f;

	public RawImage mountain;
	public RawImage floor;
	public RawImage trees;
	public RawImage branches;

	public enum GameState {Playing, Pause};
	public GameState gameState = GameState.Pause;

	public GameObject player;

	void Start () {
		
	}

	void Update () {
		if (gameState == GameState.Playing) {
			Parallax ();
			player.SendMessage ("UpdateState", "Run");
		}
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

	public void Parallax() {
		float finalSpeedMountain = mountainSpeed * Time.deltaTime;
		float finalSpeedFloor = floorSpeed * Time.deltaTime;
		float finalSpeedTrees = treesSpeed * Time.deltaTime;
		float finalSpeedBranches = branchesSpeed * Time.deltaTime;
		mountain.uvRect = new Rect (mountain.uvRect.x + finalSpeedMountain, -0.010f, 1f, 1f);
		floor.uvRect = new Rect (floor.uvRect.x + finalSpeedFloor, -0.01f, 1f, 1f);
		trees.uvRect = new Rect (trees.uvRect.x + finalSpeedTrees, 0f, 1f, 1f);
		branches.uvRect = new Rect (branches.uvRect.x + finalSpeedBranches, 0f, 1f, 1f);
	}
}
