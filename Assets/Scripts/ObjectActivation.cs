using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectActivation : MonoBehaviour
{
    [SerializeField] Color32 CanNotBeActivated = new Color32(1,1,1,1);
    [SerializeField] Color32 CanBeActivated = new Color32(1,1,1,1);
    [SerializeField] Sprite Activate;
    [SerializeField] Sprite NonActivate;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Player")
        {
            Debug.Log("Player is near");
            spriteRenderer.sprite = Activate;
        }
 
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player is to far");
            spriteRenderer.sprite = NonActivate;
        }
    }
 
}
