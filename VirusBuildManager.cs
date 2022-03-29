using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirusBuildManager : MonoBehaviour
{
    public int virusCost;

    public bool HasVirusMaterial { get { return GenPlayerStats.VirusComponent >= virusCost; } } //don't have money-> faulse, have enough money->true



    public void VirusConstruction()
    {
        if (GenPlayerStats.VirusComponent < virusCost)
        {

            Debug.Log("Can build virus yet!");
            return;

        }

        GenPlayerStats.VirusComponent -= virusCost;

        Debug.Log("Virus has been built!");

        GenPlayerStats.VirusParticle ++;

        Debug.Log("Component left: " + GenPlayerStats.VirusComponent);

    }


}
