using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    //public BoardManager boardScript;
    public int puzzlePieces = 0;
    public int keys = 0;
    [HideInInspector] public bool playersTurn = true;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

    }

    public void Update()
    {
        if (playersTurn == false)
        {
            StartCoroutine(WaitHalfSecond());
            playersTurn = true;
        }
    }

    private IEnumerator WaitHalfSecond()
    {
        yield return new WaitForSeconds(0.5f);
    }

    public void GameOver()
    {
        enabled = false;
    }
}
