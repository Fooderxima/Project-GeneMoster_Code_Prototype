using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenceUnity : MonoBehaviour
{
    public Transform target;

    [Header("Attributes")]
    public float range = 5f;
    public float fireRate = 1f; //define the rate of shooting
    private float fireCountdown = 0f; // to be specific
    public GameObject bulletPrefab;

    public float startHealth = 100;

    [Header("Unity Setup Field")]
    public string enemyTag = "Enemy";

    public Transform firePoint;



    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f); //search target twice per second
    }

    void UpdateTarget() //find the closest one
    {
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
            target = nearestEnemy.transform;
            
        }
        else
        {
            target = null;
        }
    }

    void Update()
    {
        if (target == null)
            return;

        if (fireCountdown <= 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;
        }

        fireCountdown -= Time.deltaTime;
    }

    void Shoot()
    {
        GameObject bulletGo = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        DefenceBullet bullet = bulletGo.GetComponent<DefenceBullet>(); //get bullet's script component

        if (bullet != null)
            bullet.Seek(target);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
