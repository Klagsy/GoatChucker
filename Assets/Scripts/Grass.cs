using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour {

    public float hp = 5;
	public float loss = 2;

    private SpriteRenderer spriteRenderer;

	void Awake () {
        spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	public void EatGrass () {
        hp -= loss;
        if (hp <= 0)
            gameObject.SetActive(false);
	}
}
