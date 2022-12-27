using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adult : Person
{
    private string Profession = "Waitress";
    
    private void Start()
    {
        Gender = "None";
        //Nationality = "Spanish"; // - error because  Nationality is private in Person
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Debug.Log("Hi Vlad!");
    }

    protected override void ShowAge()
    {
        Debug.Log("I'm adult!");
    }
}
