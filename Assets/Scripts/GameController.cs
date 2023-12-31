﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

	public enum GameState {Playing, Pause, Jump};
	public GameState gameState = GameState.Pause;

	public GameObject player;

	public Text timerText;
	public int timer = 3;

	void Start () {
		StartCoroutine("LoseTime");
	}

	void Update () {
		timerText.text = timer.ToString ();
		if (timer <= 0) {
			StopCoroutine("LoseTime");
			timerText.text = "";
			gameState = GameState.Playing;
		}
		if (gameState == GameState.Playing) {
			Parallax ();
			player.SendMessage ("UpdateState", "Playing");
        } else if (gameState == GameState.Pause) {
            player.SendMessage("UpdateState", "Pause");
        } 
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

	IEnumerator LoseTime() {
		while(true) {
			yield return new WaitForSeconds(1);
			timer--;
		}
	}

    public void JumpPlayer() {
        player.SendMessage("UpdateState", "Jump");
    }
}
