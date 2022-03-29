using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class defenceNumberCount : MonoBehaviour
{
    public Text defenceNumber;

    [Header("Unity Setup Field")]
    public string objectTag = "Defencer";

    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f); //search target twice per second
    }

    void UpdateTarget() //find the closest one
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag(objectTag); //using array to search enemy, and searching using the tag label on the target
    }



}
