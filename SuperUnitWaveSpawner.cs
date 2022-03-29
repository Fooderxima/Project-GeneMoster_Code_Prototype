using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperUnitWaveSpawner : MonoBehaviour
{
    public Transform defenceunitePrefab;

    public Transform defenceuniteSpawnPoint;

    private int waveNumber = 1;

    public void SuperUniteControl()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Defencer");
        if (gos.Length > 20)
        {

            for (int i = 0; i < 20; i++)
            {
                Debug.Log("Unite loss!");
                
            }

            Debug.Log("SuperUnite On Mission!");
            SpawnWave();

        }
        else
        {
            Debug.Log("Fusion has Failed!");
            return;
        }

    }

    void SpawnWave()
    {

        for (int i = 0; i < waveNumber; i++)
        {
            SpawnBattleUnite();
        }


    }

    void SpawnBattleUnite()
    {
        Instantiate(defenceunitePrefab, defenceuniteSpawnPoint.position, defenceuniteSpawnPoint.rotation);

        return;           
    }


}
