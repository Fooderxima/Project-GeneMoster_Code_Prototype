using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperUniteMovement : MonoBehaviour
{


    public float speed = 15f;

    private Transform target;
    private int wavepointIndex = 0;




    void Start()
    {
        target = SuperUniteWayPoint.points[0];
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World); //Time.deltaTime make sure that the move of enemy not depend on frame

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }

    }

    void GetNextWaypoint()
    {
        if (wavepointIndex >= SuperUniteWayPoint.points.Length - 1)
        {
            return;
        }

        wavepointIndex++;
        target = SuperUniteWayPoint.points[wavepointIndex];
    }



}
