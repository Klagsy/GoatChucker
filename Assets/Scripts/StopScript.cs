using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopScript : MonoBehaviour {

    Rigidbody2D rig;

	// Use this for initialization
	void Start () {
        rig = GetComponent<Rigidbody2D>(); // get the rigidbody component from the player
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        // if the player colides with an object that is tagged with, "Death"
        if (coll.gameObject.tag == "Object")
        {
            // make this play an animation and a sound
            // the current flag is destroyed
            rig.velocity = Vector2.zero;
        } // if
    }
}
