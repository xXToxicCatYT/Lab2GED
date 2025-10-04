using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BombCube : MonoBehaviour, ICube
{
    public void Reveal()
    {
        Debug.Log("BOOM! You clicked a bomb!");
        GetComponent<SpriteRenderer>().color = Color.red;
    }
}
