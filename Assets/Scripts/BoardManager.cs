using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BoardManager : MonoBehaviour {

    

    public int columns = 11;
    public int rows = 8;
    public GameObject[] grassTiles;
    public GameObject[] wallTiles;
    private Transform boardHolder;
    
    void boardSetup ()
    {
        boardHolder = new GameObject("board").transform;
        for (int x=-1; x<columns+1; x++)
        {
            for (int y=-1; y<rows; y++)
            {
                GameObject toInstantiate = grassTiles[Random.Range (0, grassTiles.Length)];

                if (x == -1 || x == columns|| x==5 || y == -1 || y == rows-1)
                    toInstantiate = wallTiles[Random.Range (0, wallTiles.Length)];
                GameObject instance =
                    Instantiate(toInstantiate, new Vector3(x, y, 0f), Quaternion.identity) as GameObject;
                instance.transform.SetParent(boardHolder);
            }
        }
    }

	// Use this for initialization
	public void SetupScene ()
    {
        boardSetup();
    }

}
