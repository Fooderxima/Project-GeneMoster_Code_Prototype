using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusPartGain : MonoBehaviour
{

    public float timeBetweenWaves = 5f;
    private float countdown = 5f;

    void Update()
    {
        if (countdown <= 0f)
        {
            Debug.Log("1");
            PartsGain();
            countdown = timeBetweenWaves;
            Debug.Log("10");
        }

        countdown -= Time.deltaTime;

    }

    void PartsGain()
    {
        GenPlayerStats.VirusComponent += GenPlayerStats.Lives;
    }
           
}
