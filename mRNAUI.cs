using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mRNAUI : MonoBehaviour
{
    public Text mRNAText;

    public Text materialText;


    // Update is called once per frame
    void Update()
    {
        mRNAText.text = "mRNA:" + GenPlayerStats.Lives.ToString();


        materialText.text = "CopyMachine:" + GenPlayerStats.Material.ToString();

    
    }
}
