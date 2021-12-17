using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDetecter : MonoBehaviour
{
    public bool Donthit = true;
    public bool Detected = false;
    void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.tag == "Word")
        {
            Donthit = false;
            Detected = true;
            Debug.Log("Detected");
        }        
    }
}
