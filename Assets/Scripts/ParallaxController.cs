﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParallaxController : MonoBehaviour {

	public float parallaxSpeed = 0.01f;
	public RawImage background;
	public RawImage platform;	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Parallax() {
		float finalSpeed = parallaxSpeed * Time.deltaTime;
		background.uvRect = new Rect (background.uvRect.x + finalSpeed, 0f, 1f, 1f);
		platform.uvRect = new Rect (platform.uvRect.x + finalSpeed * 8, 0f, 1f, 1f);
	}
}
