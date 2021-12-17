using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDeleter : MonoBehaviour
{    
    void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.tag == "Word")
        {            
            //Destroy(gameObject);
            //Debug.Log("Deleted");
        }        
    }
}
