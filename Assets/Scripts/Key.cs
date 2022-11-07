using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;

public class Key : MonoBehaviour
{
    public float speed = 5f;
    private Transform target;
    //public GameObject gridCollision;
    //public GameObject KeyCollision;

    public bool playerHasKey = false;

    private void Update()
    {
        if (target != null)
        {
            playerHasKey = true;
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, target.position, step);
            
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            target = other.transform;

            if (target != null)
            {
                Physics2D.IgnoreLayerCollision(6, 12);
                
            }
        }
    }
}
