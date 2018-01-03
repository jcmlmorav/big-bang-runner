using UnityEngine;
using System.Collections;

public class FollowCharacter : MonoBehaviour {

	public Transform character;
	public float distance = 6f;

	void Update () {
		transform.position = new Vector3(character.position.x+distance, transform.position.y, transform.position.z);
	}
}
