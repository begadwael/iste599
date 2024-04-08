using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speachEvent : GameEvent
{    
    [Header("Speach Settings")]
    [SerializeField] private Narratormessage message;
    [SerializeField] private Canvas speachCanvas;

    public override void triggerEvent()
    {
        speachCanvas.gameObject.SetActive(true);
        speachCanvas.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = message.message;
        speachCanvas.GetComponentInChildren<UnityEngine.UI.Image>().sprite = message.PortraitImage;
    }
}
