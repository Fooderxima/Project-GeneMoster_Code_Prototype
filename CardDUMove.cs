using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDUMove : MonoBehaviour
{
    public GameObject CardDU;


    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, CardDU.transform.position, Time.deltaTime);
    }
}
