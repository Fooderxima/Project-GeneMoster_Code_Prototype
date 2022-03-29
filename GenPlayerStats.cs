using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenPlayerStats : MonoBehaviour
{
    public static int Lives;
    public int startLives = 1;

    public static int Material;
    public int startMaterial = 0;

    public static int VirusComponent;
    public int startVirusComponent = 0;

    public static int VirusParticle;
    public int startVirusParticles = 0;

    public static int Rounds; //track plays' rounds of survive


    void Start()
    {
        Lives = startLives;

        Material = startMaterial;

        VirusComponent = startVirusComponent;

        VirusParticle = startVirusParticles;

        Rounds = 0;
    }
}
