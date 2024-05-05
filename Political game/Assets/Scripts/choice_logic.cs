using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choice_logic : MonoBehaviour
{
    [SerializeField] private Narratormessage message_yes;
    [SerializeField] private Narratormessage message_no;

    [SerializeField] private Canvas speachCanvas;
    [SerializeField] private Canvas choiceMasterCanvas;

    [SerializeField] private Canvas choiceMasterChoiceCanvas;
    [SerializeField] private Canvas new_master_menu;

    [SerializeField] private SpriteRenderer ppf_sprite;

    private bool hasAnswered = false;

    private void Start() {
        speachCanvas.gameObject.SetActive(false);
    }

    public void yes(){
        speachCanvas.gameObject.SetActive(true);
        choiceMasterCanvas.gameObject.SetActive(false);
        choiceMasterChoiceCanvas.gameObject.SetActive(false);
        ppf_sprite.sprite = message_yes.PortraitImage;
        speachCanvas.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = message_yes.message;
        new_master_menu.gameObject.SetActive(false);
        hasAnswered = true;
    }

    public void no(){
        speachCanvas.gameObject.SetActive(true);
        choiceMasterCanvas.gameObject.SetActive(false);
        choiceMasterChoiceCanvas.gameObject.SetActive(false);
        ppf_sprite.sprite = message_no.PortraitImage;
        speachCanvas.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = message_no.message;
        new_master_menu.gameObject.SetActive(false);
        hasAnswered = true;
    }

    void Update()
    {
        if (speachCanvas.gameObject.activeSelf && hasAnswered)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                speachCanvas.gameObject.SetActive(false);
                hasAnswered = false;
            }
        }
    }
}
