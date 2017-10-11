// this script allows the user to move our player

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {

    public float speed = 1; // this is the speed of our player
    Rigidbody2D rig; // this is our player's rigidbody

    Vector2 newPosition = new Vector2(0, 0); // this is for where the object is moving torwards
    string currentKey = "n"; // this will hold the direction for input on where player is moving next
                             // a = left, s = down, d = right, w = up, n = not moving

    // Use this for initialization
    void Start () {
        rig = GetComponent<Rigidbody2D>(); // get the rigidbody component from the player
    }
	
	// Update is called once per frame
	void Update () {
        Move();
       
    }
    void Move()
    {
        // instructions are 5 down, on a, they are the same for all with different directions to move
        if (Input.GetKeyDown("a") && Input.GetKeyDown("s"))
        {
            if (rig.velocity != Vector2.zero)
                currentKey = "as";

            if (currentKey == "n")
            {
                newPosition = rig.position + Vector2.left + Vector2.down;

                rig.velocity = new Vector2(-speed, -speed);
            }
        }

        else if (Input.GetKeyDown("a") && Input.GetKeyDown("w"))
        {
            if (rig.velocity != Vector2.zero)
                currentKey = "aw";

            if (currentKey == "n")
            {
                newPosition = rig.position + Vector2.left + Vector2.up;

                rig.velocity = new Vector2(-speed, speed);
            }
        }

        else if (Input.GetKeyDown("d") && Input.GetKeyDown("s"))
        {
            if (rig.velocity != Vector2.zero)
                currentKey = "ds";

            if (currentKey == "n")
            {
                newPosition = rig.position + Vector2.right + Vector2.down;

                rig.velocity = new Vector2(speed, -speed);
            }
        }

        else if (Input.GetKeyDown("d") && Input.GetKeyDown("w"))
        {
            if (rig.velocity != Vector2.zero)
                currentKey = "dw";

            if (currentKey == "n")
            {
                newPosition = rig.position + Vector2.right + Vector2.up;

                rig.velocity = new Vector2(speed, speed);
            }
        }

        else if (Input.GetKeyDown("a")) // check if player pressed left key and the object isn't moving
        {
            if (rig.velocity != Vector2.zero) // check to see if the body was already moving when they pressed this
                currentKey = "a"; // make a mark that they want to move left when the current movement is over

            if (currentKey == "n") // check to make sure the body isn't moving and has nowhere it wants to go
            {
                newPosition = rig.position + Vector2.left; // set newPosition equal to the position we want to move our
                                                           // vector torwards, in this case our current position and one left.
                rig.velocity = new Vector2(-speed, 0); // set object to move torwards that point at a speed determined in unity
            }
        }

        else if (Input.GetKeyDown("s"))
        {
            if (rig.velocity != Vector2.zero)
                currentKey = "s";

            if (currentKey == "n")
            {
                newPosition = rig.position + Vector2.down;

                rig.velocity = new Vector2(0, -speed);
            }
        }

        else if (Input.GetKeyDown("d"))
        {
            if (rig.velocity != Vector2.zero)
                currentKey = "d";

            if (currentKey == "n")
            {
                newPosition = rig.position + Vector2.right;

                rig.velocity = new Vector2(speed, 0);
            }
        }

        else if (Input.GetKeyDown("w"))
        {
            if (rig.velocity != Vector2.zero)
                currentKey = "w";

            if (currentKey == "n")
            {
                newPosition = rig.position + Vector2.up;

                rig.velocity = new Vector2(0, speed);
            }
        }

        if (rig.position == newPosition) // check if the current position is the position we've been moving torwards
            rig.velocity = new Vector2(0, 0); // stop moving

        // check if there's an order to move left and down, and that we're not moving at the moment
        if (currentKey == "as" && rig.velocity == Vector2.zero)
        {
            // repeat the movement steps from before
            newPosition = rig.position + Vector2.left + Vector2.down;

            rig.velocity = new Vector2(-speed, -speed);
            // set direction they want to go to n to signify that we're done moving after this
            currentKey = "n";
        }
        // repeat this for the other directions

        else if (currentKey == "aw" && rig.velocity == Vector2.zero)
        {
            newPosition = rig.position + Vector2.left + Vector2.up;

            rig.velocity = new Vector2(-speed, speed);

            currentKey = "n";
        }

        else if (currentKey == "ds" && rig.velocity == Vector2.zero)
        {
            newPosition = rig.position + Vector2.right + Vector2.down;

            rig.velocity = new Vector2(speed, -speed);

            currentKey = "n";
        }

        else if (currentKey == "dw" && rig.velocity == Vector2.zero)
        {
            newPosition = rig.position + Vector2.right + Vector2.up;

            rig.velocity = new Vector2(speed, speed);

            currentKey = "n";
        }

        else if (currentKey == "a" && rig.velocity == Vector2.zero)
        {
            newPosition = rig.position + Vector2.left;

            rig.velocity = new Vector2(-speed, 0);
 
            currentKey = "n";
        }

        else if (currentKey == "s" && rig.velocity == Vector2.zero)
        {

            newPosition = rig.position + Vector2.down;

            rig.velocity = new Vector2(0, -speed);

            currentKey = "n";
        }

        else if (currentKey == "d" && rig.velocity == Vector2.zero)
        {
            newPosition = rig.position + Vector2.right;

            rig.velocity = new Vector2(speed, 0);

            currentKey = "n";
        }

        else if (currentKey == "w" && rig.velocity == Vector2.zero)
        {
            newPosition = rig.position + Vector2.up;

            rig.velocity = new Vector2(0, speed);

            currentKey = "n";
        }


    }
}
