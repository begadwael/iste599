using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faction : MonoBehaviour
{
    
    [SerializeField] private string factionName;
    [SerializeField] private Color factionColor;
    [SerializeField] private List<Faction> enemies;
    [SerializeField] private List<Faction> allies;

    [SerializeField] private float support;
    [SerializeField] private float factionSize;
    [SerializeField] private float factionPower;

    public float Support { get => support; set => support = value; }

    public float FactionSize { get => factionSize; set => factionSize = value; }

    public float FactionPower { get => factionPower; set => factionPower = value; }

    public string FactionName { get => factionName; set => factionName = value; }

    public Color FactionColor { get => factionColor; set => factionColor = value; }

    public List<Faction> Enemies { get => enemies; set => enemies = value; }

    public List<Faction> Allies { get => allies; set => allies = value; }

    public bool IsEnemy(Faction faction)
    {
        return enemies.Contains(faction);
    }

    public bool IsAlly(Faction faction)
    {
        return allies.Contains(faction);
    }



}
