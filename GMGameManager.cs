using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMGameManager : MonoBehaviour
{

    public static bool gameEnded;

    public GameObject gameOverUI;


    void Start()
    {
        gameEnded = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameEnded)
            return;

        if (GenPlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        gameEnded = true;

        gameOverUI.SetActive(true);
        Debug.Log("Game Over!");
    }
}
