using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFactory
{
    public static GameObject CreateCube(GameObject safePrefab, GameObject bombPrefab, Vector2 position, bool isBomb)
    {
        GameObject prefabToUse = isBomb ? bombPrefab : safePrefab;
        GameObject cube = GameObject.Instantiate(prefabToUse, position, Quaternion.identity);
        return cube;
    }
}

