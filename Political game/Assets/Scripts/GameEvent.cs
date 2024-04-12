using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvent : MonoBehaviour
{
    [Header("Time Settings")]
    public bool isTriggeredByTime = false;
    public float timeToTrigger;

    [Header("Collider Settings")]
    public bool isTriggeredByCollider = false;
    public Collider2D triggerCollider;

    [Header("Debug")]
    public bool isTriggered = false;

    
    public virtual void triggerEvent()
    {
        Debug.Log("Event Triggered");
    }

    

}
