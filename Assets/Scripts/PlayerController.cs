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

	public void UpdateState(string state = null) {
		if (state != null) {
			animator.Play (state);
		}
	}
}
