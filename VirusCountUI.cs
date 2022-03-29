using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirusCountUI : MonoBehaviour
{
    public Text virusCountNumber;

    // Update is called once per frame
    void Update()
    {
        virusCountNumber.text = GenPlayerStats.VirusParticle.ToString() + "/20";

    }
}
