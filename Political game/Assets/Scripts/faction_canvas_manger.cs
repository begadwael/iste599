using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faction_canvas_manger : MonoBehaviour
{
    [Header("factions")]
    [SerializeField] private PoliticalFaction Corpratefaction;
    [SerializeField] private PoliticalFaction BigPharmaFaction;
    [SerializeField] private PoliticalFaction MilitaryFaction;
    [SerializeField] private PoliticalFaction BigTechFaction;

    [Header("UI")]
    [SerializeField] private TMPro.TextMeshProUGUI CorpratefactionText;
    [SerializeField] private TMPro.TextMeshProUGUI BigPharmaFactionText;
    [SerializeField] private TMPro.TextMeshProUGUI MilitaryFactionText;
    [SerializeField] private TMPro.TextMeshProUGUI BigTechFactionText;



    private void Update()
    {
        CorpratefactionText.text = Corpratefaction.Support.ToString();
        BigPharmaFactionText.text = BigPharmaFaction.Support.ToString();
        MilitaryFactionText.text = MilitaryFaction.Support.ToString();
        BigTechFactionText.text = BigTechFaction.Support.ToString();
    }


}
