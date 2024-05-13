using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rally_choice : MonoBehaviour
{
    [SerializeField] private speachEvent speachEvent;

    [SerializeField] private Narratormessage choice_message;

    [SerializeField] private Narratormessage narratormessage_yes;
    [SerializeField] private Narratormessage narratormessage_no;

    [SerializeField] private Canvas choiceCanvas;
    [SerializeField] private Canvas speachCanvas;
    [SerializeField] private SpriteRenderer ppf_sprite;
    [SerializeField] private TMPro.TextMeshProUGUI text;


    private bool isTriggered = false;

    private void Update() {
        if (speachEvent.messages.Count == 0 & isTriggered == false)
        {
            isTriggered = true;
            choiceCanvas.gameObject.SetActive(true);
            
        }
        if (isTriggered)
        {
            if (Input.GetKeyDown(KeyCode.Space)){
                speachCanvas.gameObject.SetActive(false);
            }
        }
    }

    public void yes()
    {
        choiceCanvas.gameObject.SetActive(false);
        speachCanvas.gameObject.SetActive(true);
        ppf_sprite.sprite = narratormessage_yes.PortraitImage;
        text.text = narratormessage_yes.message;
        ppf_sprite.sprite = narratormessage_yes.PortraitImage;

    }


    public void no()
    {
        choiceCanvas.gameObject.SetActive(false);
        speachCanvas.gameObject.SetActive(true);
        ppf_sprite.sprite = narratormessage_no.PortraitImage;
        text.text = narratormessage_no.message;
        ppf_sprite.sprite = narratormessage_no.PortraitImage;
    }

}
