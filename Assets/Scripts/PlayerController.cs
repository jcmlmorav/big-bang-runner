using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Animator animator;

	void Start () {
		animator = GetComponent<Animator> ();
	}

	void Update () {
		
	}

	public void UpdateState(string gameState = null) {
		if (gameState != null) {
			switch (gameState) {
			case "Playing":
				animator.SetBool ("run", true);
				break;
			case "Pause":
				animator.SetBool( "run", false);
				break;
			}
		}
	}
}
