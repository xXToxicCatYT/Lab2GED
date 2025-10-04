using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject safeCubePrefab;
    public GameObject bombCubePrefab;

    public Vector2 startPosition = new Vector2(-4f, 0f);

    void Start()
    {
        int bombIndex = Random.Range(0, 4);

        for (int i = 0; i < 4; i++)
        {
            bool isBomb = (i == bombIndex);
            Vector2 pos = startPosition + new Vector2(i * 2, 0); 
            CubeFactory.CreateCube(safeCubePrefab, bombCubePrefab, pos, isBomb);
        }
    }
}

