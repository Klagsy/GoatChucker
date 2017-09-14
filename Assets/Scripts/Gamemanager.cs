using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour {

    public static Gamemanager instance = null;
    private BoardManager boardScript;

	// Use this for initialization
	void Awake () {
        boardScript = GetComponent<BoardManager>();
        InitGame();
	}
	
	// Update is called once per frame
	void InitGame () {
        boardScript.SetupScene();
	}
}
