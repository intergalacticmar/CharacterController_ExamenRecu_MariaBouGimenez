using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        float movementMagnitude = new Vector2(horizontal, vertical).sqrMagnitude;

        if (movementMagnitude > 0.1f)
        {
            animator.SetBool("IsWalking", false);
            animator.SetBool("IsIdle", false);
        }
        else if (movementMagnitude > 0f)
        {
            animator.SetBool("IsWalking", true);
            animator.SetBool("IsIdle", false);
        }
        else
        {
            animator.SetBool("IsWalking", false);
            animator.SetBool("IsIdle", true);
        }
    }
}