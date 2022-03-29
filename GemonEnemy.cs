using UnityEngine;
using UnityEngine.UI;

public class GemonEnemy : MonoBehaviour
{
    public float startSpeed = 10f;

    public Transform target;

    [Header("Attributes")]
    public float range = 15f;
    public float fireRate = 1f; //define the rate of shooting
    private float fireCountdown = 0f; // to be specific
    public GameObject bulletPrefab;

    [Header("Unity Setup Field")]
    public string enemyTag = "Defencer";

    //public string sEnemyTag = "SDefencer";

    public Transform firePoint;


    [HideInInspector] //make the speed still can be extract to the other scripts, bit noe show up in the control panel 
    public float speed;

    public float startHealth = 100;
    private float health;


    void Start()
    {
        speed = startSpeed; //announce a speed that prevent the slow funtion adds on target per frame, using the startspeed to let the system recount each frame
        health = startHealth;

        InvokeRepeating("UpdateTarget", 0f, 0.2f); //search target five times per second
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
        GemonEnemyBullet bullet = bulletGo.GetComponent<GemonEnemyBullet>(); //get bullet's script component

        if (bullet != null)
            bullet.Seek(target);
    }

    public void TakeDamage(float amount) //access this function at Bullet script
    {
        health -= amount;


        if (health <= 0)
        {
            Die();
        }

    }


    void Die() //operate die function
    {
        Destroy(gameObject);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }


}
