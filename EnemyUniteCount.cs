using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyUniteCount : MonoBehaviour
{
    public Text EUCountText;

    
    // Update is called once per frame
    void Update()
    {
        EUCountText.text = "Enemy Unite:" + GameObject.FindGameObjectsWithTag("Enemy").Length.ToString();


    }
}

