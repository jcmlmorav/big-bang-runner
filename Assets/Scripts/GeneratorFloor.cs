using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorFloor : MonoBehaviour {

    public Transform prefab;
    public float timeClone = 48f;

    // Use this for initialization
    void Start () {
        Generate();
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    void Generate() {
		float finalSpeed = timeClone * Time.deltaTime;
        Instantiate(prefab, transform.position, Quaternion.identity);
		Invoke("Generate", finalSpeed);
    }
}
