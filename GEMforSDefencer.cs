using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GEMforSDefencer : MonoBehaviour
{

    public float speed = 10f;

    private Transform target;
    private int wavepointIndex = 0;

    [Header("Unity Setup Field")]
    public string sEnemyTag = "SDefencer";

    public float range = 10f;

    void Start()
    {
        target = EnemyWayPoints.points[0];
    }

    void Update()
    {

        Vector3 dirSE = target.position - transform.position;
        transform.Translate(dirSE.normalized * speed * Time.deltaTime, Space.World); //Time.deltaTime make sure that the move of enemy not depend on frame
        GameObject[] sEnemies = GameObject.FindGameObjectsWithTag(sEnemyTag); //using array to search enemy, and searching using the tag label on the target
        float shortestDistanceSE = Mathf.Infinity;
        GameObject nearestSEnemy = null;

        foreach (GameObject sEnemy in sEnemies)
        {
            float distanceToSEnemy = Vector3.Distance(transform.position, sEnemy.transform.position);
            if (distanceToSEnemy < shortestDistanceSE)
            {
                shortestDistanceSE = distanceToSEnemy;
                nearestSEnemy = sEnemy;
            }
        }

        if (nearestSEnemy != null && shortestDistanceSE <= range)
        {
            return;
        }

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }
        else
        {
            return;
        }

    }

    void GetNextWaypoint()
    {
        if (wavepointIndex >= EnemyWayPoints.points.Length - 1)
        {
            EndPath();
            return;
        }

        wavepointIndex++;
        target = EnemyWayPoints.points[wavepointIndex];
    }

    void EndPath()
    {
        GenPlayerStats.Lives--;

        Destroy(gameObject);

    }

}