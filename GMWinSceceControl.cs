using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMWinSceceControl : MonoBehaviour
{

    public static bool gameWon;

    public GameObject gameWinUI;


    void Start()
    {
        gameWon = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameWon)
            return;

        if (GenPlayerStats.VirusParticle >= 20)
        {
            GameWin();
        }
    }

    void GameWin()
    {
        gameWon = true;

        gameWinUI.SetActive(true);
        Debug.Log("You win!");
    }
}

