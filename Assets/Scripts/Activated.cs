using UnityEngine;


[RequireComponent(typeof(SpriteRenderer))]

public class Activated : Interacteble
{
    [SerializeField] Sprite activeted;
    [SerializeField] Sprite deactivate;

    private SpriteRenderer sr;
    private bool isActivated;

    public override void Interact()
    {
        if (isActivated)
            sr.sprite = deactivate;
        else
            sr.sprite = activeted;

        isActivated = !isActivated;
    }

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = deactivate;
    }
}
