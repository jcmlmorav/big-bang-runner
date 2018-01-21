using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BranchesScript : MonoBehaviour {

	public float branchesSpeed = 0.2f;
	public RawImage branches;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Parallax() {
		float finalSpeedBrances = branchesSpeed * Time.deltaTime;
		branches.uvRect = new Rect (branches.uvRect.x + finalSpeedBrances, 0f, 1f, 1f);
	}
}
