using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;        //Store a component reference to the attached SpriteRenderer.


    void Awake()
    {
        //Get a component reference to the SpriteRenderer.
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
}