using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Animator animator;
   

    void Start () {
		animator = GetComponent<Animator> ();
      
    }

	void Update () {
        if (Input.GetKeyDown("up") || Input.GetMouseButtonDown(0)) { 
            SendMessage("UpdateState", "Jump"); 
        }
        if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("Hero1Jump")) {
            SendMessage("UpdateState", "StopJump");
        }
    }

	public void UpdateState(string gameState = null) {

		if (gameState != null) {
            switch (gameState)
            {
                case "Playing":
                    animator.SetBool("run", true);
                    break;
                case "Pause":
                    animator.SetBool("run", false);
                    break;
                case "Jump":
                    animator.SetBool("jump", true);
                    break;
                case "StopJump":
                    animator.SetBool("jump", false);
                    break;
            }
        }
	}
}
