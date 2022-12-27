using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Child : Person
{
    private void Start()
    {
        //Name = "Ihor";
        Gender = "Female";
        //Nationality = "German"; // - error because  Nationality is private in Person
        
    }
    
    
}
