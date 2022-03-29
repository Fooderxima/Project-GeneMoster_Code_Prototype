using UnityEngine;

public class DefenceBullet : MonoBehaviour
{
    private Transform target;

    public float speed = 50f;

    public int damage = 100;
    public GameObject impactEffect;

    public void Seek(Transform _target)
    {
        target = _target;
    }

    void Update()
    {
        if (target == null) //find bullet's target
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame) //hit the target
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World); // normalize make the distance doesn't affect bullet's speed. Space.world make sure it move relative to global space


    }

    void HitTarget()
    {
        GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectIns, 5f);


        Damage(target);
        

        //Destroy(target.gameObject);
        Destroy(gameObject);
    }


    void Damage(Transform enemy)
    {
        GemonEnemy e = enemy.GetComponent<GemonEnemy>(); //using "e" to separate the new variable to the transform enemy

        if (e != null)
        {
            e.TakeDamage(damage);
        }

        //Destroy(enemy.gameObject);
    }
}
