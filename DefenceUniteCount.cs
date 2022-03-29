using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenceUniteCount : MonoBehaviour
{
    public Text DUCountText;



    // Update is called once per frame
    void Update()
    {
        DUCountText.text = "Defence Unite:" + GameObject.FindGameObjectsWithTag("Defencer").Length.ToString();

        
    }
}
