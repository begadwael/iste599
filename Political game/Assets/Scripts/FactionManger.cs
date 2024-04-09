using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactionManger : MonoBehaviour
{
    [SerializeField] private List<PoliticalFaction> factions;

    public List<PoliticalFaction> Factions { get => factions; set => factions = value; }

    private void Update() {
        foreach (PoliticalFaction faction in factions)
        {
            Debug.Log(faction.FactionName + " has " + faction.Support + " support");
        }
    }

    


}
