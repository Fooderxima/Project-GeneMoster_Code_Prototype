using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GemonWaveSpawner : MonoBehaviour
{

    public Transform enemyPrefab;
    //public Transform defenceunitePrefab;

    public Transform enemySpawnPoint;
    //public Transform defenceuniteSpawnPoint;

    public float timeBetweenWaves = 5f;
    private float countdown = 5f;

    public Text waveCountdownText;

    private int waveNumber = 1;

    void Update()
    {
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;

        }

        countdown -= Time.deltaTime;
        
        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);

        waveCountdownText.text = string.Format("{0:00.00}", countdown);
    }

    IEnumerator SpawnWave()
    {
     
        for (int i = 0; i < waveNumber; i++)
        {
            SpawnBattleUnite();
            yield return new WaitForSeconds(0.5f);

        }


        waveNumber++;
    }

    void SpawnBattleUnite() 
        //cannot separate the spqwn function into enemy and defence part, it could influence the waveNumber setting 
        //maybe the other option is to set another WaveSpawner to serve the defence part 
    {
        Instantiate(enemyPrefab, enemySpawnPoint.position, enemySpawnPoint.rotation);
    }
       

}
