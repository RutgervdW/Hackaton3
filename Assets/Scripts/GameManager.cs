using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    //public BoardManager boardScript;
    public int puzzlePieces = 0;
    public int keys = 0;
    public TextMeshProUGUI puzzlePiecesText;
    public TextMeshProUGUI keysText;

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
        keysText.text = "Keys:" +keys.ToString();
        puzzlePiecesText.text = "Puzzle Pieces: " + puzzlePieces.ToString();
    }

    public void GameOver()
    {
        enabled = false;
    }
}
