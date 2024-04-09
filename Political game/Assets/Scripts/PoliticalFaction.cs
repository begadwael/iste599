using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliticalFaction : MonoBehaviour
{
    
    [SerializeField] private string factionName;
    [SerializeField] private Color factionColor;
    [SerializeField] private List<PoliticalFaction> enemies;
    [SerializeField] private List<PoliticalFaction> allies;

    [SerializeField] private float support;
    [SerializeField] private float factionSize;
    [SerializeField] private float factionPower;

    public float Support { get => support; set => support = value; }

    public float FactionSize { get => factionSize; set => factionSize = value; }

    public float FactionPower { get => factionPower; set => factionPower = value; }

    public string FactionName { get => factionName; set => factionName = value; }

    public Color FactionColor { get => factionColor; set => factionColor = value; }

    public List<PoliticalFaction> Enemies { get => enemies; set => enemies = value; }

    public List<PoliticalFaction> Allies { get => allies; set => allies = value; }

    public bool IsEnemy(PoliticalFaction faction)
    {
        return enemies.Contains(faction);
    }

    public bool IsAlly(PoliticalFaction faction)
    {
        return allies.Contains(faction);
    }

    public void addsupport(float amount)
    {
        support += amount;
    }

    public void removesupport(float amount)
    {
        support -= amount;
    }

    public void addsupportbypercentage(float percentage)
    {
        support += support * percentage;
    }

    public void removesupportbypercentage(float percentage)
    {
        support -= support * percentage;
    }

    public void addsize(float amount)
    {
        factionSize += amount;
    }

    public void addsizebypercentage(float percentage)
    {
        factionSize += factionSize * percentage;
    }

    public void removesize(float amount)
    {
        factionSize -= amount;
    }

    public void removesizebypercentage(float percentage)
    {
        factionSize -= factionSize * percentage;
    }

    public void addpower(float amount)
    {
        factionPower += amount;
    }

    public void addpowerbypercentage(float percentage)
    {
        factionPower += factionPower * percentage;
    }

    public void removepower(float amount)
    {
        factionPower -= amount;
    }

    public void removepowerbypercentage(float percentage)
    {
        factionPower -= factionPower * percentage;
    }








}
