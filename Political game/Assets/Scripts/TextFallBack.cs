using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextFallBack : MonoBehaviour
{

    [SerializeField] private List<ChoiceMasterText> choiceMasterTexts;
    [SerializeField] private Canvas ChoiceMasterCanvas;
    [SerializeField] private TimeManger timeManger;

    [SerializeField] private TextMeshProUGUI text;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.activeSelf){
            timeManger.isRunning = false;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (choiceMasterTexts.Count > 0)
                {
                    if (choiceMasterTexts.Count == 1)
                    {
                        ChoiceMasterCanvas.gameObject.SetActive(true);
                    }
                    text.text = choiceMasterTexts[0].message;
                    choiceMasterTexts.RemoveAt(0);
                }
            } 
        }
    }

    public void closeChoiceMaster()
    {
        timeManger.isRunning = true;
        ChoiceMasterCanvas.gameObject.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
