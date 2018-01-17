using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour {

    public float speed = 2.5f;

	void Start () {
        
    }
	
	void FixedUpdate () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
    }
}
