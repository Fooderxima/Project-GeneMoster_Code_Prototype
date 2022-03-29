using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefencerWaveSpawner : MonoBehaviour
{

    public Transform defenceunitePrefab;

    public Transform defenceuniteSpawnPoint;


    public float timeBetweenWaves = 5f;
    private float countdown = 5f;


    private int waveNumber = 1;


    void Update()
    {
        if (countdown <= 0f)
        {
            Debug.Log("1");
            SpawnWave();
            countdown = timeBetweenWaves;
            Debug.Log("10");
        }
                
        countdown -= Time.deltaTime;
        
    }

    void SpawnWave()
    //IEnumerator SpawnWave()
    {
        
        for (int i = 0; i < waveNumber; i++)
        {

            
            SpawnBattleUnite();

            //yield return new WaitForSeconds(0.5f);

        }

        


        Debug.Log("DN" + waveNumber);
        waveNumber += GenPlayerStats.Lives - waveNumber;
        Debug.Log("DN" + waveNumber);


    }

    void SpawnBattleUnite()
    //cannot separate the spqwn function into enemy and defence part, it could influence the waveNumber setting 
    //maybe the other option is to set another WaveSpawner to serve the defense part 
    {
        //   Instantiate(enemyPrefab, enemySpawnPoint.position, enemySpawnPoint.rotation);
        Debug.Log("5");

        Instantiate(defenceunitePrefab, defenceuniteSpawnPoint.position, defenceuniteSpawnPoint.rotation);

        
      
    }



}
