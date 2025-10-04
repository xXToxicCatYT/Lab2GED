using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeCube : MonoBehaviour, ICube
{
    public void Reveal()
    {
        Debug.Log("Safe cube clicked!");
        GetComponent<SpriteRenderer>().color = Color.green;
    }
}


