using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour {

    public float speed = 2.5f;
    private Animator animator;

	void Start () {
        animator = GetComponent<Animator>();
    }
	
	void FixedUpdate () {
        //GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
    }

    public void UpdateState(string state = null) {
        if (state != null) {
            animator.Play(state);
        }
    }
}
