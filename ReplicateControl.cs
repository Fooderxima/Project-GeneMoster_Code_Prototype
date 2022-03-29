using UnityEngine;

public class ReplicateControl : MonoBehaviour
{
    public int materialCost;

    public bool HasMaterial { get { return GenPlayerStats.Material >= materialCost; } } //don't have money-> faulse, have enough money->true

    public void ReplicationCycle ()
    {
        if (GenPlayerStats.Material < materialCost)
        {

            Debug.Log("Not enough material to replicate!");
            return;

        }

        GenPlayerStats.Material -= materialCost;

        Debug.Log("Replicated");

        Debug.Log("Live " + GenPlayerStats.Lives);

        GenPlayerStats.Lives = GenPlayerStats.Lives * 2;

        Debug.Log("Live " + GenPlayerStats.Lives);

        Debug.Log("Replication complete! Material left: " + GenPlayerStats.Material);

    }

}
