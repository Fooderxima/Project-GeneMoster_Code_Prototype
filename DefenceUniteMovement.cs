using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenceUniteMovement : MonoBehaviour
{


    public float speed = 15f;

    private Transform target;
    private int wavepointIndex = 0;


    //[Header("General")]
    //public string defencerTag = "Defencer";
    //public float range = 10f;

    void Start()
    {
        target = DefenceUniteWayPoints.points[0];
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
        if (wavepointIndex >= DefenceUniteWayPoints.points.Length - 1)
        {
        //    Fusion();
            return;
        }

        wavepointIndex++;
        target = DefenceUniteWayPoints.points[wavepointIndex];
    }

    //void Fusion()
    //{
    //    
    //        GameObject[] defencers = GameObject.FindGameObjectsWithTag(defencerTag);
    //        float shortestDistance = Mathf.Infinity;
    //        GameObject nearestDefencer = null;

    //        foreach (GameObject defencer in defencers)
    //        {
    //            float distanceToDefencer = Vector3.Distance(transform.position, defencer.transform.position);
    //            if (distanceToDefencer < shortestDistance)
    //            {
    //                shortestDistance = distanceToDefencer;
    //                nearestDefencer = defencer;
    //            }
    //        }

    //        if (nearestDefencer != null && shortestDistance <= range)
    //        {
    //            target = nearestDefencer.transform;
    //            targetDefencer = nearestDefencer.GetComponent<Defencer>();
    //        }
    //        else
    //        {
    //            target = null;
    //        }


    //}

}
