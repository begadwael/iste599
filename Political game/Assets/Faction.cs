using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PoliticalFaction : MonoBehaviour
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

    

    public void AddSupport(float support)
    {
        this.support += support;
    }

    public void AddSupportByPercentage(float percentage)
    {
        this.support += this.support * percentage;
    }

    public void LoseSupport(float support)
    {
        this.support -= support;
    }

    public void LoseSupportByPercentage(float percentage)
    {
        this.support -= this.support * percentage;
    }
    
    public void AddFactionSize(float factionSize)
    {
        this.factionSize += factionSize;
    }

    public void AddFactionSizeByPercentage(float percentage)
    {
        this.factionSize += this.factionSize * percentage;
    }

    public void LoseFactionSize(float factionSize)
    {
        this.factionSize -= factionSize;
    }

    public void LoseFactionSizeByPercentage(float percentage)
    {
        this.factionSize -= this.factionSize * percentage;
    }


    public List<Faction> getEnemies()
    {
        return enemies;
    }

    public List<Faction> getAllies()
    {
        return allies;
    }

}
