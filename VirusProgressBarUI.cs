using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirusProgressBarUI : MonoBehaviour
{
    public float finalParticle = 20;
    public Image progressBar;

    public void Update()
    {
    
        progressBar.fillAmount = GenPlayerStats.VirusParticle / finalParticle;
    }

}
