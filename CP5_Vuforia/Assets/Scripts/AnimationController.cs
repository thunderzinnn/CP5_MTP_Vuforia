using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;

    private bool canInteract = false;

    void Update()
    {
        CheckTouch();
    }


    public void EnableInteraction()
    {
        canInteract = true;
    }

    public void DisableInteraction()
    {
        canInteract = false;
    }

    void CheckTouch()
    {
        if (!canInteract)
            return;

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                PlayAnimation();
            }
        }
    }

    void PlayAnimation()
    {
        animator.Play("Attack");
    }
}

