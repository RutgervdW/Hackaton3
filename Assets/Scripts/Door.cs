using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public GameObject key;
    private Key keyScript;

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
}
