using System.Collections;
using System.Collections.Generic;
using CorutinesAndEvents.Scripts;
using UnityEngine;

public class EventTester2 : MonoBehaviour
{
    [SerializeField] private EventsSample _eventsSample;
    
    void OnEnable()
    {
        _eventsSample.MyEmptyEvent += Print;
        _eventsSample.MyIntEvent += PrintInt;
    }
    
    private void OnDisable()
    {
        _eventsSample.MyEmptyEvent -= Print;
        _eventsSample.MyIntEvent -= PrintInt;
    }

    private void Print()
    {
        Debug.Log("Event Tester 2");
    }

    private void PrintInt(int i)
    {
        Debug.Log("EventTester2 " + i); 
    }
}
