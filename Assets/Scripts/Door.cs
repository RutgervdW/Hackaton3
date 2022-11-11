using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public GameObject key;
    private Key keyScript;
    private Transform target;
    public GameObject door;

    private void Start()
    {
        keyScript = key.GetComponent<Key>();
    }

    void Update()
    {
        if (keyScript.playerHasKey)
        {
            gameObject.layer = LayerMask.NameToLayer("Default");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (keyScript.playerHasKey)
            {
                Destroy(key);

                door.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            }


        }
    }
}
