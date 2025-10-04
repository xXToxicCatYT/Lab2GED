using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeClickHandler : MonoBehaviour
{
    void OnMouseDown()
    {
        ICube cube = GetComponent<ICube>();
        if (cube != null)
        {
            cube.Reveal();
        }
    }
}

