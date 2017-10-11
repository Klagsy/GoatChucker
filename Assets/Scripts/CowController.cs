using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowController : MonoBehaviour {
	public float speed = 1;
	Rigidbody2D rig;
	public Grass grass;



	// Use this for initialization
	void OnTriggerEnter2D (Collider2D collision) {
		if (collision.gameObject.tag == "Grass") {
			grass.EatGrass();
			Debug.Log ("grass eat");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
