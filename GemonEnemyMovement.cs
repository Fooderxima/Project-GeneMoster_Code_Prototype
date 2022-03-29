using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemonEnemyMovement : MonoBehaviour
{

    public float speed = 10f;

    private Transform target;
    private int wavepointIndex = 0;

    [Header("Unity Setup Field")]
    public string enemyTag = "Defencer";

    public float range = 10f;

    void Start()
    {
        target = EnemyWayPoints.points[0];
    }

    void Update()
    {

        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World); //Time.deltaTime make sure that the move of enemy not depend on frame
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag); //using array to search enemy, and searching using the tag label on the target
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && shortestDistance <= range)
        {
            return;
        }

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
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

