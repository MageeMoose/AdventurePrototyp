using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interacteble : MonoBehaviour
{
    public abstract void Interact();

    private void OnTriggerEnter2D(Collider2D other) 
    {
        
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            
        }   
    }

    
}
