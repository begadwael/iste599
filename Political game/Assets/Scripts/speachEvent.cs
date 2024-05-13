using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class speachEvent : GameEvent
{    
    [Header("Speach Settings")]
    [SerializeField] private Narratormessage message;

    [Header("Series Settings")]
    [SerializeField] bool isSeries= false;
    [SerializeField] public List<Narratormessage> messages;


    [Header("UI Settings")]
    [SerializeField] private Canvas speachCanvas;
    [SerializeField] private SpriteRenderer ppf_sprite;

    public override void triggerEvent()
    {
        speachCanvas.gameObject.SetActive(true);
        ppf_sprite.sprite = message.PortraitImage;
        speachCanvas.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = message.message;
        
    }


    private void Update() {
        if (speachCanvas.gameObject.activeSelf)
        {
            if (isSeries)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (messages.Count > 0)
                    {
                        message = messages[0];
                        messages.RemoveAt(0);
                        ppf_sprite.sprite = message.PortraitImage;
                        speachCanvas.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = message.message;
                    }
                    else
                    {
                        speachCanvas.gameObject.SetActive(false);
                    }
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    speachCanvas.gameObject.SetActive(false);
                }
            }     
        }   
    }
}
