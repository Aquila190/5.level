using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private float moveInput;

    void Start()
    {
        
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
        moveInput = Input.GetAxisRaw("Horizontal");

        
        if (moveInput != 0)
        {
            animator.SetBool("isRunning", true);

            
            if (moveInput > 0) 
            {
                spriteRenderer.flipX = false; 
            }
            else if (moveInput < 0) 
            {
                spriteRenderer.flipX = true; 
            }
        }
        else
        {
            animator.SetBool("isRunning", false); 
        }
    }
}
