using UnityEngine;

public class JumpNewScript : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float jumpForce = 10f;
    [SerializeField] private Transform feetPos;
    [SerializeField] private float radius = 0.2f;
    [SerializeField] private LayerMask layermask;
    [SerializeField] private float gravityScale = 1f;
    [SerializeField] private float fallGravityScale = 2.5f;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = gravityScale;
    }

    private void Update()
    {
        HandleJump();
        AdjustGravity();
    }

    private void HandleJump()
    {
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce); 
        }

        if (Input.GetButtonUp("Jump") && rb.linearVelocity.y > 0)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y * 0.5f);
        }
    }

    private void AdjustGravity()
    {
        if (rb.linearVelocity.y < 0)
        {
            rb.gravityScale = fallGravityScale; 
        }
        else
        {
            rb.gravityScale = gravityScale; 
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(feetPos.position, radius, layermask);
    }
}
