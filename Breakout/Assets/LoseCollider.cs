using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	public LevelManager levelmanager;
	
	void OnTriggerEnter2D (Collider2D trigger) {
		print ("Trigger");
		levelmanager.LoadLevel("Win");
	}
	
	void OnCollisionEnter2D (Collision2D collision) {
		print ("Collision");
	}
}
