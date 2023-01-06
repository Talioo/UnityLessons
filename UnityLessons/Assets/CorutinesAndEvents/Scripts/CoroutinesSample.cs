using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutinesSample : MonoBehaviour
{
    private Coroutine _coroutine;
    
    void Start()
    {
        _coroutine = StartCoroutine(SampleCoroutine());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
           StopCoroutine(_coroutine);
        }
    }

    private IEnumerator SampleCoroutine()
    {
        Debug.Log("Hi!");

        StartCoroutine(SampleCoroutine2());
        
        while (!Input.GetKey(KeyCode.K))
        {
            yield return new WaitForSeconds(0.3f);
            yield return new WaitForFixedUpdate();
            
            yield return null;//before update
            yield return new WaitForEndOfFrame();//after update
            
            Debug.Log("Wait..."); 
        }
        
        Debug.Log("End");
    }
    
    private IEnumerator SampleCoroutine2()
    {
        Debug.Log("Hi Corutine 2!");

        while (!Input.GetKey(KeyCode.D))
        {
            yield return new WaitForSeconds(0.3f);
            Debug.Log("Wait Corutine 2...");
        }
        
        Debug.Log("End Corutine 2");
    }
}
