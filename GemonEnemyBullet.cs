using UnityEngine;

public class GemonEnemyBullet : MonoBehaviour
{
    private Transform target;

    public float speed = 10f;
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

        Destroy(target.gameObject);
        Destroy(gameObject);
    }
}
