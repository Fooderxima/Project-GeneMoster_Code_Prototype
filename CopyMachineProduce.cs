using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyMachineProduce : MonoBehaviour
{

    public float timeBetweenWaves = 5f;
    private float countdown = 5f;

    void Update()
    {
        if (countdown <= 0f)
        {
            Debug.Log("1");
            CopyMachineGenerate();
            countdown = timeBetweenWaves;
            Debug.Log("10");
        }

        countdown -= Time.deltaTime;

    }

    void CopyMachineGenerate()
    {
        GenPlayerStats.Material += GenPlayerStats.Lives * 20;
    }

}
