using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParallaxController : MonoBehaviour {

	public float mountainSpeed = 0.01f;
	public float platformSpeed = 0.016f;
	public RawImage background;
	public RawImage platform;	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Parallax() {
		float finalSpeedMountain = mountainSpeed * Time.deltaTime;
		float finalSpeedPlatform = platformSpeed * Time.deltaTime;
		background.uvRect = new Rect (background.uvRect.x + finalSpeedMountain, -0.010f, 1f, 1f);
		platform.uvRect = new Rect (platform.uvRect.x + finalSpeedPlatform * 8, -0.01f, 1f, 1f);
	}
}
