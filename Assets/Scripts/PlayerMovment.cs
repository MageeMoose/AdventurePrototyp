using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Animator animator;
    [SerializeField] GameObject interactIcon;
    
    private Vector2 boxSize = new Vector2(0.1f,1f);
    Vector2 movement;


    private void Start()
    {
        interactIcon.SetActive(false);
    }
    void Update()
    {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if (Input.GetKeyDown(KeyCode.E))
        {
            CheckInteraction();
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    public void OpenInteractiveIcon()
    {
        interactIcon.SetActive(true);
    }

    public void CloseInteractiveIcon()
    {
        interactIcon.SetActive(false);
    }

    public void CheckInteraction()
    {
        RaycastHit2D[] hits = Physics2D.BoxCastAll(transform.position, boxSize, 0, Vector2.zero);

        if(hits.Length > 0)
        {
            foreach(RaycastHit2D rc in hits)
            {
                if(rc.transform.GetComponent<Interacteble>())
                {
                    rc.transform.GetComponent<Interacteble>().Interact();
                    return;
                }
            }
        }
    }
}
