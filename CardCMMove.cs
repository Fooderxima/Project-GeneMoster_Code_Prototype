using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCMMove : MonoBehaviour

{
    public GameObject CardCM;                           
                                                       
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, CardCM.transform.position, Time.deltaTime);
    }
}

