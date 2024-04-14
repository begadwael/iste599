using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using System;

public class TimeManger : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeText;

    private float time = 0;
    [SerializeField] private float timeToStop = 0;
    [SerializeField] private float timemultiplier = 6f; // 6x speed = 1 hour in 1 minutes
    [SerializeField] public bool isRunning = false;

    // List of all the events that will be triggered at a certain time
    [SerializeField] private List<GameEvent> gameEvents = new List<GameEvent>();

    
    private void Update()
    {
        if (isRunning)
        {
            time += Time.deltaTime * timemultiplier;
            if (TimeSpan.FromSeconds(time) >= TimeSpan.FromHours(4)){
                timeText.text = TimeSpan.FromSeconds(time + (9*60)).ToString(@"mm") + " PM";
            }else{
                timeText.text = TimeSpan.FromSeconds(time +(9*60)).ToString(@"mm") + " AM";
            
            }
            // timeText.text = TimeSpan.FromSeconds(time).ToString(@"mm") + " hours";
        }else if (time >= timeToStop)
        {
            isRunning = false;
        }

        // Check if any of the events should be triggered
        foreach (GameEvent gameEvent in gameEvents)
        {
            if (!gameEvent.isTriggered && time >= gameEvent.timeToTrigger && gameEvent.isTriggeredByTime)
            {
                gameEvent.isTriggered = true;
                gameEvent.triggerEvent();
            }
        }
    }
}
