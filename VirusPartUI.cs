using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirusPartUI : MonoBehaviour
{
    public Text virusPartNumber;

    // Update is called once per frame
    void Update()
    {
        virusPartNumber.text = GenPlayerStats.VirusComponent.ToString();
    }
}
