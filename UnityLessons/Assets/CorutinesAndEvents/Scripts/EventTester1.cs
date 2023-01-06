using System;
using System.Collections;
using System.Collections.Generic;
using CorutinesAndEvents.Scripts;
using UnityEngine;

public class EventTester1 : MonoBehaviour
{
    [SerializeField] private EventsSample _eventsSample;
    
    void OnEnable()
    {
        _eventsSample.MyEmptyEvent += Print;
    }

    private void OnDisable()
    {
        _eventsSample.MyEmptyEvent -= Print;
    }

    private void Print()
    {
        Debug.Log("Event Tester 1");
    }
}
